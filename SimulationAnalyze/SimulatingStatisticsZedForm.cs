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
using Analysis.PartsForm;
using Analysis.FormUtils;

namespace Analysis
{
    public partial class SimulatingStatisticsZedForm : ZedGraphBase
    {

        public InteractiveAgent agent = InteractiveAgent.getInstance();
        private ReqStr reqStr = ReqStr.getInstance();
        public string simuURL;//datacollect1-1-1-30-50
        private string stepValueURL;

        private List<Statsitic> simuCurrentList;
        PointPairList list = null, dynamicList = new PointPairList();
        private static int id = 0;
        private CurveList myCurveList = new CurveList();
        
        public SimulatingStatisticsZedForm()
        {
            InitializeComponent();
            reqStr.Url();
            simuURL = reqStr.SimuURL;
            stepValueURL = reqStr.StepValueURL;
            InitializationAttributes();
            createZedPane2();
        }

        //初始化成员属性
        private void InitializationAttributes()
        {
            this.stepFromTextBox.Text = model.getStartStep();
            this.stepToTextBox.Text = model.getEndStep();
            this.title = "时域分析图";
            this.yText = "数值";
            this.xText = "时间";
            simuCurrentList = new List<Statsitic>();
            startStep = model.getStartStep();
            endStep = model.getEndStep();
        }
   
        protected override void dynamicTimer_Tick(object sender, EventArgs e)
        {
            if (id < list.Count)
            {
                if (this.myCurve != null)
                {
                    this.myPane.CurveList.Remove(myCurve);
                }
                if (dynamicList.Count == list.Count)
                {
                    dynamicList.Clear();
                }
                dynamicList.Add(next(list));
                myCurve = myPane.AddCurve("MyCurve", dynamicList, Color.DarkGreen, SymbolType.None);
                this.zedGraphControl.AxisChange();
                this.zedGraphControl.Refresh();
            }
            else
            {
                id = 0;
                this.dynamicTimer.Enabled = false;
                MessageBox.Show("载入数据结束！", "温馨提示", MessageBoxButtons.OK);
            }
        }

        //获取下一个点——---------------------------------------
        private PointPair next(PointPairList list)
        {
            if (id == 0)
            {
                id++;
                return list[0];

            }
            return list[id++];
        }
        //动态载入
        public PointPairList createDynamicZedPane()
        {
            if (myPane == null)
            {
                return null;
            }
            if (myPane.CurveList.Capacity != 0)
            {
                ZedUtils.removeAllCurves(myPane.CurveList);
                ZedUtils.removeAllCurves(myCurveList);
                this.zedGraphControl.AxisChange();
                this.zedGraphControl.Refresh();
               // MessageBox.Show("null");
            }

            PointPairList list;
            string reqStrTest = "";
            reqStrTest = reqStrTest + model.GetLateIdStatus()[0] + "-";//方案
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1] + "-";//成员1
            reqStrTest = reqStrTest + model.GetHistoryrun()[0] + "-";// 运行次数
            reqStrTest = reqStrTest + model.getStartStep() + "-";//步长
            reqStrTest = reqStrTest + model.getEndStep();
            Console.WriteLine(reqStrTest);
            list = ZedUtils.getStepValueFromService(stepValueURL,reqStrTest);
            addAllSimuStaCurves(null);
            return list;
        }
        //调用服务静态载入数据
        public void createStaticZedPane()
        {
            PointPairList list2;
            string reqStrTest = getSiumReqStr();
            list2 = ZedUtils.getStepValueFromService(stepValueURL, reqStrTest);
            if (myPane == null)
            {
                return;
            }
            if (myPane.CurveList.Capacity != 0)
            {
                ZedUtils.removeAllCurves(myPane.CurveList);
                ZedUtils.removeAllCurves(myCurveList);
            }
            myCurve = myPane.AddCurve("MyCurve", list2, Color.DarkGreen, SymbolType.None);
            addAllSimuStaCurves(null);

            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }

        private string getSiumReqStr()
        {
            string reqStrTest = "";
            reqStrTest = reqStrTest + model.GetLateIdStatus()[0] + "-";//方案
            reqStrTest = reqStrTest + model.GetHistoryrun()[0] + "-";// 运行次数
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1] + "-";//成员1
            reqStrTest = reqStrTest + model.getStartStep() + "-";//步长
            reqStrTest = reqStrTest + model.getEndStep();
            Console.WriteLine(reqStrTest);
            return reqStrTest;
        }

        //载入Zed基本信息
        public override void createZedPane2()
        {
            this.myPane = null;
            String reqStr = "-" + startStep + "-" + endStep;
            this.myPane = this.zedGraphControl.GraphPane;
            myPane.Title.Text = title;
            myPane.YAxis.Title.Text = yText;
            myPane.XAxis.Title.Text = xText;
            setZedAction();
            XMax = Double.Parse(endStep);
            XMin = Double.Parse(startStep);
            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }

        //接收中介类通知:去model里取统计数据-----------------------
        public void informedToGetCurSimuList()
        {
            simuCurrentList = model.getSimuCurrentList();
            ZedUtils.showRequeredStaCurves(simuCurrentList, myCurveList);//显示要求的统计数据
            zedGraphControl.AxisChange();//一定要
            Refresh();
        }

        //绘图区域绘制所有统计图像…………………………………………………………………………………………………………………………
        private void addAllSimuStaCurves(string reqStr)
        {
            double y;
            PointPairList list1;
            List<Statsitic> allStaList = ZedUtils.getStatsticsFromService(simuURL,getSiumReqStr());//reqStr

            if (allStaList == null)
            {
                return;
            }
            model.setAllSimuStatistic(allStaList);

            agent.informSimuStastisticFromRefreshNewData();

            for (int j = 0; j < allStaList.Count; j++)
            {
                list1 = new PointPairList();
                for (double x = XMin; x < XMax; x = x + 1)
                {
                    y = allStaList[j].Val;
                    list1.Add(x, y);
                }
                LineItem myCurve = myPane.AddCurve(allStaList[j].Type, list1, GetRandomColor(), SymbolType.None);
                this.myCurveList.Add(myCurve);
                myPane.Legend.IsVisible = false;
                myCurve.Line.IsSmooth = true;
                myCurve.IsVisible = false;
            }
        }
       
       
        //重置步长以后，刷新显示________________________________________________
        protected override void redrawButton_Click(object sender, EventArgs e)
        {
            createStaticZedPane();
            agent.informSimuWndAllNonCheck();
        }

        //默认按钮
        protected override void defaultButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myCurveList.Count; i++)
            {
                myCurveList[i].IsVisible = false;
            }
            agent.informSimuWndAllNonCheck();
        }

        //载入数据响应----------------------------------------------
        protected override void loadDataButton_Click(object sender, EventArgs e)
        {
            LoadDataForm loadDataForm = new LoadDataForm();
            loadDataForm.ShowDialog();
            if (loadDataForm.DialogResult == DialogResult.OK)
            {
                if (model.getDynamicLoad() == false)
                {

                    createStaticZedPane();
                }
                else
                {
                    list = createDynamicZedPane();
                    this.dynamicTimer.Enabled = true;
                }
            }

        }
      
    }
}
