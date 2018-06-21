using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Analysis
{
    public partial class DataZedGraphicForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {

        public SchemeModel model = SchemeModel.getInstance();
        public DataFromService service = new DataFromService();
        private ReqStr reqStr = ReqStr.getInstance();

        string stepValueURL;


        private string reqStrTest;
        //方案名-仿真次数-属性名-起始步长-终止步长


        public PointPairList getStepValueFromService(string reqStr)
        {
            PointPairList list = new PointPairList();
            string result = service.HttpGet(stepValueURL + reqStr);
            string[] arrStepValue = result.Split('-');
            for (int i = 0; i < arrStepValue.Length-2; i = i + 2)
            {
                list.Add(Double.Parse(arrStepValue[i]), Double.Parse(arrStepValue[i + 1]));
            }
            return list;
        }
        private PointPairList getPoint(int runtime)
        {
            PointPairList list;
            string reqStrTest = "";
            reqStrTest = reqStrTest + model.GetLateIdStatus()[0] + "-";//方案
            reqStrTest = reqStrTest + model.GetHistoryrun()[runtime] + "-";// 运行次数
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1] + "-";//成员1
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1] + "-";//属性1

            reqStrTest = reqStrTest + model.getStartStep() + "-";//步长
            reqStrTest = reqStrTest + model.getEndStep();
            Console.WriteLine(reqStrTest);
            list = getStepValueFromService(reqStrTest);
            return list;
        }
        //分别存储,方案名.方案成员,方案属性,方案的第几次
        public List<string> schememessage= new List<string>();
        public List<int> runtimessage = new List<int>();


        public DataZedGraphicForm()
        {
            InitializeComponent();
            reqStr.Url();
            stepValueURL = reqStr.StepValueURL;
            model.setStartStep(this.startStepTextBox.Text);
            model.setEndStep(this.endStepTextBox.Text);
            // InitDraw();

        }




        //传递过来的信息
        public void SchemeMessage()
        {
            schememessage = model.GetLateNameStatus();
            if (runtimessage.Count != 0) {
                runtimesage();
            }

        }
        public void runtimesage()
        {
            runtimessage = model.GetHistoryrun();

            InitDraw();



        }


        //根据传来的信息进行方案的选择


        #region
        public void InitDraw()
        {
            if (schememessage.Count == 3 && runtimessage.Count != 0)
            {

                CreateGraph_static(this.zedGraphControl1);
                this.zedGraphControl1.GraphPane.CurveList.Clear();
                this.zedGraphControl1.GraphPane.GraphObjList.Clear();
                for (int i = 0; i < runtimessage.Count; i++)
                {
                    PointPairList list = getPoint(i);
                    TestResultForm2(list);
                }

                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();//刷新
            }
            else
            {
                this.zedGraphControl1.GraphPane.CurveList.Clear();
                this.zedGraphControl1.GraphPane.GraphObjList.Clear();
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();//刷新
            }
        }
        //信息的初始化
        public void CreateGraph_static(ZedGraphControl zedgraphcontrol)
        {

            //#region 现实特征设置

            GraphPane myPane = zedgraphcontrol.GraphPane;

            //// Change the color of the title 改变标题的颜色
            //myPane.Title.FontSpec.FontColor = Color.Green;

            //// Add gridlines to the plot, and make them gray 网格线添加到情节,灰色
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.Color = Color.Gray;
            myPane.YAxis.MajorGrid.Color = Color.Gray;

            //myPane.XAxis.Scale.Format = "yyyy-MM-dd  HH:mm:ss";   //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") 
            //myPane.XAxis.Scale.Max = 5;
            //myPane.XAxis.Scale.MinorStep = 0.1;

            myPane.XAxis.Scale.FontSpec.Angle = 75; //横坐标字体角度
            zedgraphcontrol.GraphPane.Title.FontSpec.Size = 20;
            zedgraphcontrol.AutoScroll = true;
            // zedgraphcontrol.GraphPane.XAxis.Type = ZedGraph.AxisType.DateAsOrdinal; //X轴属性类型
            zedgraphcontrol.PanModifierKeys = Keys.Shift;//移动坐标图



            zedgraphcontrol.GraphPane.XAxis.MajorTic.PenWidth = 8.0F;


            //myPane.XAxis.Scale.FontSpec.Size = 14;  //字号 ,最好不要设置

            //myPane.XAxis.Scale.FontSpec.IsBold = true;     //是不是粗体
            //myPane.XAxis.Scale.FontSpec.Border.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            //#endregion

        }
        public Color ExchangeColor()
        {

            Random RandomNum_First = new Random((int)DateTime.Now.Ticks);
            //  对于C#的随机数，没什么好说的
            System.Threading.Thread.Sleep(RandomNum_First.Next(50));
            Random RandomNum_Sencond = new Random((int)DateTime.Now.Ticks);

            //  为了在白色背景上显示，尽量生成深色
            int int_Red = RandomNum_First.Next(256);
            int int_Green = RandomNum_Sencond.Next(256);
            int int_Blue = (int_Red + int_Green > 400) ? 0 : 400 - int_Red - int_Green;
            int_Blue = (int_Blue > 255) ? 255 : int_Blue;

            return Color.FromArgb(int_Red, int_Green, int_Blue);




            


        }
        #endregion



        public void TestResultForm(PointPairList list1)
        {


            GraphPane my = this.zedGraphControl1.GraphPane;
            List<int> list = new List<int>();
          

            LineItem myCurve;



            myCurve = my.AddCurve("对比数据", list1,ExchangeColor(), SymbolType.Circle);

           


        }
        public void TestResultForm2(PointPairList list1)
        {
            GraphPane myPane = this.zedGraphControl1.GraphPane;
            ZedGraphControl zedgraphcontrol = this.zedGraphControl1;
            LineItem myCurve;//第一条折线

            //设置一个数组

            zedgraphcontrol.GraphPane.Title.Text = "参数折线图";
            zedgraphcontrol.GraphPane.XAxis.Title.Text = "步长";
            zedgraphcontrol.GraphPane.YAxis.Title.Text = "数量";

            myCurve = myPane.AddCurve("对比数据", list1, ExchangeColor(), SymbolType.Circle);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            model.setStartStep(this.startStepTextBox.Text);
            model.setEndStep(this.endStepTextBox.Text);
            InitDraw();

        }

        private void endStepTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void startStepTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void endStepTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(endStepTextBox.Text);
                model.setEndStep(endStepTextBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("请输入数字", "温馨提示", MessageBoxButtons.OK);
            }
        }

        private void startStepTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(startStepTextBox.Text);
                model.setStartStep(startStepTextBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("请输入数字", "温馨提示", MessageBoxButtons.OK);
            }
        }
    }

}

