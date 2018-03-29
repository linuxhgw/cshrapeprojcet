using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using ZedGraph;
using System.Windows.Forms;
using System.Collections;

namespace Analysis
{
    public partial class BasicalStastisticsZedForm : ZedGraphBase
    {
        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();
        public DataFromService service = new DataFromService();
        public string staURL = "http://stuzhou:5555/api-analysis/getBasicStatisticsAnalysis?reqStr=";
        private string stepValueURL = "http://stuzhou:5555/api-analysis/getAtrributeRunData?reqStr=";//datacollect0-1-3-30-50
        private List<Statsitic> staCurrentList;      //实时要显示的统计数据列表
        private string startStep, endStep;


        public BasicalStastisticsZedForm()
        {
            InitializeComponent();
            InitializationAttributes();
            createZedPane2();

        }

            //初始化成员属性
        private void InitializationAttributes()
        {
            this.stepFromTextBox.Text = model.getStartStep();
            this.stepToTextBox.Text = model.getEndStep();
            this.title = "动态折线图";
            this.yText = "数量";
            this.xText = "数量";
            staCurrentList = new List<Statsitic>();
            startStep = model.getStartStep();
            endStep = model.getEndStep();
        }

        //调用服务返回点集，………………………………………………
        public PointPairList getStepValueFromService(string reqStr)
        {
            PointPairList list = new PointPairList();
            string result = service.HttpGet(stepValueURL + reqStr);
            string[] arrStepValue = result.Split('-');
            for (int i = 0; i + 1 < arrStepValue.Length; i = i + 2)
            {
                list.Add(Double.Parse(arrStepValue[i]), Double.Parse(arrStepValue[i + 1]));
            }
            return list;
        }
   
        //?*服务*/、加载窗体时调用此方法获取四个统计值并返回，**顺序一定：最大、最小、平均值、方差………………………………………………
        public List<Statsitic> getStatsticsFromService(string reqStr)
        {
            int j = 0;
            List<Statsitic> list = new List<Statsitic>();
            Statsitic sta;
            String results = service.HttpGet(staURL + reqStr);
            string[] arrSta = results.Split('-');
            while (j + 1 < arrSta.Length)
            {
                sta = new Statsitic(arrSta[j], Math.Round(System.Convert.ToDouble(arrSta[j + 1]), 3));
                list.Add(sta);
                j = j + 2;
            }
            return list;
        }

        public override void createZedPane2()
        {
          //  MessageBox.Show("初始化面板");
            LineItem myCurve;
            PointPairList list;
            String reqStr = "-" + startStep + "-" + endStep;
            this.myPane = this.zedGraphControl.GraphPane;
            myPane.Title.Text = title;
            myPane.YAxis.Title.Text = yText;
            myPane.XAxis.Title.Text = xText;
            setZedAction();
            list = getStepValueFromService("datacollect0-1-3-30-50");
            XMax = Double.Parse(endStep);
            XMin = Double.Parse(startStep);
          
   //         MessageBox.Show(startStep + "," + endStep + "," + XMin.ToString() + "," + XMax.ToString());
            myCurve = myPane.AddCurve("MyCurve", list, Color.DarkGreen, SymbolType.None);
            addAllStaCurves(null);
            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }

        //接收中介类通知:去model里取统计数据-----------------------
        public void informedToGetCurStaList()
        {
            staCurrentList = model.getStaCurrentList();
            showRequeredStaCurves();//显示要求的统计数据
        }

        //绘图区域绘制所有统计图像…………………………………………………………………………………………………………………………
        private void addAllStaCurves(string reqStr)
        {
            double y;
            PointPairList list1;
            List<Statsitic> allStaList = getStatsticsFromService("datacollect0-1-3-30-50");//reqStr
            model.setAllStatistic(allStaList);
            if (allStaList == null)
            {
                return;
            }

            for (int j = 0; j < allStaList.Count; j++)
            {
                list1 = new PointPairList();
                for (double x = XMin; x < XMax; x = x + 1)
                {
                    y = allStaList[j].Val;
                    list1.Add(x, y);
                }
                LineItem myCurve = myPane.AddCurve(allStaList[j].Type, list1, Color.Blue, SymbolType.None);
                myPane.Legend.IsVisible = false;
                myCurve.Line.IsSmooth = true;
                myCurve.IsVisible = false;
            }
        }

        //绘图区域显示的统计数据的曲线----------------------------------------
        private void showRequeredStaCurves()
        {

            if (staCurrentList == null)
            {
                return;
            }

            for (int i = 1; i < myPane.CurveList.Count; i++)
            {
                this.myPane.CurveList[i].IsVisible = false;

            }
            for (int i = 0; i < staCurrentList.Count; i++)
            {
                int index = this.myPane.CurveList.IndexOf(staCurrentList[i].Type);
                if (index > 0)
                {
                    this.myPane.CurveList[index].IsVisible = true;
                }
            }
            zedGraphControl.AxisChange();//一定要
            Refresh();
        }

        //显示默认事件-------------------------------------
        private void defaultButton_Click(object sender, EventArgs e)
        {
            createZedPane2();
            agent.informStaWndAllNonCheck();
        }

        //重置步长以后，刷新显示
        private void redrawButton_Click(object sender, EventArgs e)
        {
            createZedPane2();
            agent.BasicalRefresh();
            agent.informStaWndAllNonCheck();
        }
    }
}
