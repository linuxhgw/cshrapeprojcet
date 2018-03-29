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
    public partial class AssociatedZedForm : ZedGraphBase
    {
        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();
        public DataFromService service = new DataFromService();
        private string stepValueURL = "http://stuzhou:5555/api-analysis/getAtrributeRunData?reqStr=";
    
        //关联属性的名称
        private string attribute1 = "";
        private string attribute2 = "";
        private int start, end;
        public AssociatedZedForm()
        {
            InitializeComponent();
            createZedPane2();
        }
        //调用服务返回点集
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

        //*服务*/调用两次服务取两个属性的点集……………………………………………………………………………………………………………………
        ////reqStr:方案名(0)-成员(1)-属性(2)-运行次数(3)-起始步长(4)-终止步长(5)
        //方案名(0)-成员(1)-运行次数(2)-起始步长(3)-终止步长(4)
        public PointPairList setXYPoints(String requsteStr)
        {
            //MessageBox.Show("setxy");
            PointPairList list1 = getStepValueFromService("datacollect0-1-3-30-50");//假ù的?//第一个属性
            PointPairList list2 = getStepValueFromService("datacollect0-1-3-30-50");//另一个属性
            PointPairList destXY = new PointPairList();
            end=start =(Int32)list1[0].Y;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].Y < start)
                    start = (Int32)list1[i].Y;
                else if((Int32)list1[i].Y>end)
                    end = (Int32)list1[i].Y;
                destXY.Add(list1[i].Y, list2[i].Y);
            }

            return destXY;
        }
        //设置关联的属性集,并由此设置面板属性--------------------
        public void setAtrributes()
        {
            if (model.getAssociatedAttibuteName() != null)
            {
                List<string> states= model.GetLateNameStatus();          
                attribute1= states[2];
                attribute2 = model.getAssociatedAttibuteName();
                this.xText = attribute1;
                this.yText = attribute2;
                this.title = this.yText + "-" + this.xText;
            }
        }

        public override void createZedPane2()
        {
            this.stepFromTextBox.Text = model.getStartStep();
            this.stepToTextBox.Text = model.getEndStep();
            String reqStr = "";//请求点集的字符串；
            PointPairList destXY = setXYPoints(reqStr);
            setAtrributes();
            LineItem myCurve;
            this.myPane = this.zedGraphControl.GraphPane;
            myPane.Title.Text = title;
            myPane.YAxis.Title.Text = yText;
            myPane.XAxis.Title.Text = xText;
            setZedAction();
            myCurve = myPane.AddCurve("MyCurve", destXY, Color.DarkGreen, SymbolType.Diamond);
            // myCurve.Line.IsSmooth = true;
            this.zedGraphControl.AxisChange();            
            this.zedGraphControl.Refresh();
        }

        //增加线性直线，
        public void addLinearCurve(double[] coefficient)
        {
            if (coefficient == null)
            {
                return;
            }
           
            PointPairList list = new PointPairList();
            double x, y;
            for (double i = start; i < end; i=i+0.5)
            {
                x = i;
                y = coefficient[0] * x + coefficient[2];
                list.Add(x, y);
            }
            myPane.AddCurve("Linear" + attribute2 + attribute1, list, Color.Red, SymbolType.Circle);
            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }

        public void getcoefficient()
        {
            double[] cofficient = model.getlinearResults();
            addLinearCurve(cofficient);
        }
    }
}
