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
using Analysis.PartsForm;
using Analysis.FormUtils;

namespace Analysis
{
    public partial class BasicalStastisticsZedForm : ZedGraphBase
    {
        public InteractiveAgent agent = InteractiveAgent.getInstance();
        private ReqStr reqStr = ReqStr.getInstance();

        public string staURLTest;
        public string stepValueURLTest;
        public string staURL;
        string stepValueURL;
        private List<Statsitic> staCurrentList;      //实时要显示的统计数据列表
        private static int id = 0;
        private PointPairList list = null, dynamicList = new PointPairList(), tempDynamicList = null;
        private CurveList myCurveList = new CurveList();
        public BasicalStastisticsZedForm()

        {

            InitializeComponent();
            reqStr.Url();
            staURL = reqStr.StaURL;
            stepValueURL = reqStr.StepValueURL;
            stepFromTextBox.Text = model.getStartStep();
            stepToTextBox.Text = model.getEndStep();
            InitializationAttributes();
            createZedPane2();
        }

        //初始化成员属性
        private void InitializationAttributes()
        {
            this.stepFromTextBox.Text = model.getStartStep();
            this.stepToTextBox.Text = model.getEndStep();
            this.title = "基本分析图";
            this.yText = model.GetLateNameStatus()[1];
            this.xText = "步长";
            staCurrentList = new List<Statsitic>();
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
                if (dynamicList.Count >= list.Count)
                {
                    dynamicList.Clear();
                }
                dynamicList.Add(next(list));
                myCurve = myPane.AddCurve("MyCurve", dynamicList, Color.DarkGreen, SymbolType.Triangle);
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

        private PointPair next(PointPairList list)
        {
         
            return list[id++];
        }
        //动态载入
        public PointPairList createDynamicZedPane()
        {
            myCurveList.Clear();
            if (myPane == null)
            {
                return null;
            }
            if (myPane.CurveList.Capacity != 0)
            {
                this.zedGraphControl.GraphPane.CurveList.Clear();
                this.zedGraphControl.GraphPane.GraphObjList.Clear();
                this.zedGraphControl.AxisChange();
                this.zedGraphControl.Refresh();
                // MessageBox.Show("null");
            }
            PointPairList list;
            list = getPoint();

            addAllStaCurves();
            return list;
        }
        //调用服务静态载入数据
        //调用服务静态载入数据
        public void createStaticZedPane()
        {
            //停止动态加载
            myCurveList.Clear();
            this.dynamicTimer.Enabled = false;
            PointPairList list;
            list = getPoint();
            if (myPane == null)
            {
                return;
            }

            if (myPane.CurveList.Capacity != 0)
            {
                this.zedGraphControl.GraphPane.CurveList.Clear();
                this.zedGraphControl.GraphPane.GraphObjList.Clear();
            }
            myCurve = myPane.AddCurve("MyCurve", list, color, SymbolType.None);
            addAllStaCurves();

            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }

        private PointPairList getPoint()
        {
            PointPairList list;
            string IdList = "";
            IdList += model.GetLateIdStatus()[0] + "-";
            IdList += model.GetHistoryrun()[0] + "-";
            IdList += model.GetLateIdStatus()[1] + "-";

            IdList += model.getStartStep() + "-";
            IdList += model.getEndStep();

            Console.WriteLine(IdList);
            list = ZedUtils.getStepValueFromService(stepValueURL, IdList);
            return list;
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
            this.staCurrentList = null;
            model.setStaCurrentList(null);
            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }


        //接收中介类通知:去model里取统计数据-----------------------
        public void informedToGetCurStaList()
        {
            staCurrentList = model.getStaCurrentList();
            ZedUtils.showRequeredStaCurves(staCurrentList, myCurveList);//显示要求的统计数据
            zedGraphControl.AxisChange();//一定要
            zedGraphControl.Refresh();
        }
        //绘图区域绘制所有统计图像的数据…………………………………………………
        //添加基本统计数据在画图区
        private void addAllStaCurves()
        {
            double y;
            PointPairList list1;


            string IdList = "";
            IdList += model.GetLateIdStatus()[0] + "-";
            IdList += model.GetHistoryrun()[0] + "-";
            IdList += model.GetLateIdStatus()[1] + "-";

            IdList += model.getStartStep() + "-";
            IdList += model.getStartStep() + "-";
            IdList += model.getEndStep();
            List<Statsitic> allStaList = ZedUtils.getStatsticsFromService(staURL, IdList);//reqStr



            if (allStaList == null)
            {
                return;
            }
            model.setAllStatistic(allStaList);

            agent.informBasicalStastisticFromRefreshNewData();

            for (int j = 0; j < allStaList.Count; j++)
            {
                list1 = new PointPairList();
                for (double x = Double.Parse(model.getStartStep()); x < Double.Parse(model.getEndStep()); x = x + 1)
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



        //显示默认事件-------------------------------------
        protected override void defaultButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(myCurveList.Count.ToString());
            for (int i = 0; i < myCurveList.Count; i++)
            {
                myCurveList[i].IsVisible = false;
            }
            agent.informStaWndAllNonCheck();

        }

        private void BasicalStastisticsZedForm_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;//设置鼠标样式
        }

        //重置步长以后，刷新显示
        protected override void redrawButton_Click(object sender, EventArgs e)
        {
            model.setStartStep(stepFromTextBox.Text);
            model.setEndStep(stepToTextBox.Text);


            createStaticZedPane();
            agent.informStaWndAllNonCheck();
        }

        //载入数据响应
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
                    if (list != null && list.Count > 0)
                    {
                        list.Clear();
                        id = 0;
                        dynamicList.Clear();
                    }
                    list = createDynamicZedPane();
                    this.dynamicTimer.Enabled = true;
                }
            }

        }

    }
}
