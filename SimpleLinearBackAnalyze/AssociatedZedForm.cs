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
using Analysis.FormUtils;

namespace Analysis
{
    public partial class AssociatedZedForm : ZedGraphBase
    {
        public InteractiveAgent agent = InteractiveAgent.getInstance();
    
        public DataFromService service = new DataFromService();
        private ReqStr reqStr = ReqStr.getInstance();
        private string stepValueURL;
        CurveItem item = null;



        //关联属性的名称
        private string attribute1 = "";
        private string attribute2 = "";

        public AssociatedZedForm()
        {
            InitializeComponent();
           

            reqStr.Url();
            stepValueURL = reqStr.StepValueURL;
            this.stepFromTextBox.Text = model.getStartStep();
            this.stepToTextBox.Text = model.getEndStep();


        }
        //调用服务返回点集


   

        //*服务*/调用两次服务取两个属性的点集……………………………………………………………………………………………………………………
        ////reqStr:方案名(0)-成员(1)-属性(2)-运行次数(3)-起始步长(4)-终止步长(5)
        //方案名(0)-成员(1)-运行次数(2)-起始步长(3)-终止步长(4)
        public PointPairList setXYPoints()
        {
            //MessageBox.Show("setxy");
            string reqStrAttr1Test = "";
            reqStrAttr1Test = reqStrAttr1Test + model.GetLateIdStatus()[0] + "-";//方案
           
            reqStrAttr1Test = reqStrAttr1Test + model.GetLateIdStatus()[1] + "-";//成员1
            reqStrAttr1Test = reqStrAttr1Test + model.getAssociatedAttibuteId() + "-";//成员2
            reqStrAttr1Test = reqStrAttr1Test + model.GetHistoryrun()[0] + "-";// 运行次数
            reqStrAttr1Test = reqStrAttr1Test + model.getStartStep() + "-";//步长
            reqStrAttr1Test = reqStrAttr1Test + model.getEndStep();
            Console.WriteLine(reqStrAttr1Test);
         
            PointPairList list1 = ZedUtils.getStepValueFromService(stepValueURL, reqStrAttr1Test);//假ù的?//第一个属性
         
            return list1;
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
             this.zedGraphControl.GraphPane.CurveList.Clear();
            this.zedGraphControl.GraphPane.GraphObjList.Clear();
            item = null;
            agent.informAssociateMainClearTextbox();
            PointPairList destXY = setXYPoints();
            setAtrributes();
            this.myPane = this.zedGraphControl.GraphPane;
            myPane.Title.Text = title;
            myPane.YAxis.Title.Text = model.GetLateNameStatus()[1];
            myPane.XAxis.Title.Text =model.getAssociatedAttibuteName();
            setZedAction();
            myCurve = myPane.AddCurve("MyCurve", destXY, color, SymbolType.Diamond);
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

            if (item != null) return;
            PointPairList list = new PointPairList();
            double x, y;
            for (double i = Double.Parse(model.getStartStep()); i < Double.Parse(model.getEndStep()); i = i + 0.5)
            {
                x = i;
                y = coefficient[0] * x + coefficient[2];
                list.Add(x, y);
            }
              item =  myPane.AddCurve("Linear" + attribute2 + attribute1, list, Color.Red, SymbolType.Circle);
            this.zedGraphControl.AxisChange();
            this.zedGraphControl.Refresh();
        }

        public void getcoefficient()
        {
            double[] cofficient = model.getlinearResults();
            addLinearCurve(cofficient);
        }
        protected override void redrawButton_Click(object sender, EventArgs e) 
        {
          model.setStartStep(this.stepFromTextBox.Text);
            model.setEndStep(this.stepToTextBox.Text);

           
            createZedPane2();
        }

        protected override void loadDataButton_Click(object sender, EventArgs e)
        {
         
           
            createZedPane2();
        }

        
    }
}
