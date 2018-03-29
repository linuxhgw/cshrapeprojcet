using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ZedGraph;

namespace Analysis
{
    public partial class SimulatingStatisticsZedForm : ZedGraphBase
    {

        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();
        public DataFromService service = new DataFromService();
        public string simuURL = "http://stuzhou:5555/api-analysis/";
        private string stepValueURL = "http://stuzhou:5555/api-analysis/getAtrributeRunData?reqStr=";//datacollect0-1-3-30-50
        private List<Statsitic> simuCurrentList;

        public SimulatingStatisticsZedForm()
        {
            InitializeComponent();
            createZedPane2();
        }

      

        //初始化成员属性
        private void InitializationAttributes()
        {
            this.title = "动态折线图";
            this.yText = "数量";
            this.xText = "数量";
            simuCurrentList = new List<Statsitic>();
        }


        //调用服务返回点集，………………………………………………
        public ArrayList getDataFromServer()
        {
            return null;
        }


        //?*服务*/、加载窗体时调用此方法获取统计值并返回，**顺序一定：超调量", "调节时间", "振荡次数", "延迟时间","上升时间","峰值时间………………………………………………
        public List<Statsitic> getSimuStastisticsFromService(string reqStr)
        {
            List<Statsitic> list = new List<Statsitic>();
            Statsitic sta;
            double[] arr = { 20, 5, 10, 44, 33, 22 };//获取的值
            string[] type = { "超调量", "调节时间", "振荡次数", "延迟时间", "上升时间", "峰值时间" };
            for (int i = 0; i < arr.Length; i++)
            {
                sta = new Statsitic(type[i], arr[i]);
                list.Add(sta);
            }
            return list;
        }

        //作动态图,GetStatsticsFromService();
        //   addAllStaCurves();
        public override void createZedPane2( )
        {

            LineItem myCurve;
            this.myPane = this.zedGraphControl.GraphPane;
            myPane.Title.Text = title;
            myPane.YAxis.Title.Text = yText;
            myPane.XAxis.Title.Text = xText;
            setZedAction();
            //仅显示100个点
            double[] x = new double[36];
            double[] y = new double[36];
            for (int i = 0; i < 36; i++)
            {

                x[i] = (double)i + 5;
                y[i] = x[i] + 1;
            }
            XMin = x[0];
            XMax = x[35];
            myCurve = myPane.AddCurve("MyCurve", x, y, Color.DarkGreen, SymbolType.None);
            getSimuStastisticsFromService(null);
            addAllSimuCurves();
            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }


        //接收中介类通知:去model里取统计数据-----------------------
        public void informedToGetCurSimuList()
        {
            simuCurrentList = model.getSimuCurrentList();
            showRequeredSimuCurves();//显示要求的统计数据
        }


        //绘图区域绘制所有统计图像…………………………………………………………………………………………………………………………
        private void addAllSimuCurves()
        {
            List<Statsitic> allSimuList = getSimuStastisticsFromService(null);
            if (allSimuList == null)
            {
                return;
            }
            double y;
            PointPairList list1;
            for (int j = 0; j < allSimuList.Count; j++)
            {
                list1 = new PointPairList();
                for (double x = XMin; x < XMax; x = x + 1)
                {
                    y = allSimuList[j].Val;
                    list1.Add(x, y);
                }
                LineItem myCurve = myPane.AddCurve(allSimuList[j].Type, list1, Color.Blue, SymbolType.None);
                myPane.Legend.IsVisible = false;
                myCurve.Line.IsSmooth = true;
                myCurve.IsVisible = false;
            }
        }

        //绘图区域显示的统计数据的曲线----------------------------------------
        private void showRequeredSimuCurves()
        {

            if (simuCurrentList == null)
            {
                return;
            }

            for (int i = 1; i < myPane.CurveList.Count; i++)
            {
                this.myPane.CurveList[i].IsVisible = false;

            }
            for (int i = 0; i < simuCurrentList.Count; i++)
            {
                int index = this.myPane.CurveList.IndexOf(simuCurrentList[i].Type);
                if (index > 0)
                {
                    this.myPane.CurveList[index].IsVisible = true;
                }
            }
            zedGraphControl.AxisChange();//一定要
            Refresh();
        }


        private void defaultButton_Click(object sender, EventArgs e)
        {
            createZedPane2();
            agent.informSimuWndAllNonCheck();
        }
    }
}
