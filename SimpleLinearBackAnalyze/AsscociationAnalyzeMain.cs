using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis
{
    public partial class AsscociationAnalyzeMain : Form
    {
        private AssociatedZedForm associatedZedForm;
        private CaseInfoForm caseInfoWnd;
        private ReqStr reqStr = ReqStr.getInstance();
        private string simpLinearURL;

       

        public DataFromService service = new DataFromService();
        //attrIndex=datacollect0-3-1-2-3&steplength=1-5000";

        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();

        //string 
        public AsscociationAnalyzeMain()
        {
            InitializeComponent();
            reqStr.Url();
            simpLinearURL = reqStr.SimpLinearURL;

        }

        private void AsscociationAnalyzeMain_Load(object sender, EventArgs e)
        {
            associatedZedForm = new AssociatedZedForm();
            agent.associatedZedForm = associatedZedForm;
            associatedZedForm.MdiParent = this;
            associatedZedForm.Dock = DockStyle.Fill;
            associatedZedForm.Parent = zedWndPanel;
            associatedZedForm.Show();

            caseInfoWnd = new CaseInfoForm();
            caseInfoWnd.MdiParent = this;
            caseInfoWnd.Dock = DockStyle.Fill;
            caseInfoWnd.Parent = caseInfoWndPanel;
            caseInfoWnd.Show();
            setBasicalDataAnalyzeMainSize();
        }

        //------------------------------------------
        public void setBasicalDataAnalyzeMainSize()
        {
            //获取屏幕：不包括任务栏
            //Rectangle screenArea = System.Windows.Forms.Screen.GetWorkingArea(this);
            //包括任务栏
            Rectangle screenArea = System.Windows.Forms.Screen.GetBounds(this);
            this.Width = screenArea.Width / 2;
            this.Height = screenArea.Height / 2;
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;
            int yHeight = SystemInformation.PrimaryMonitorSize.Height;
            this.Location = new Point((xWidth - this.Width) / 2, (yHeight - this.Height) / 2);
        }

        //调用服务，取线性关系
       
        //调用服务获取相关性系数……………………………………………………………………………………
        private double[] getRelations(string reqStr)
        {
            reqStr = "attrIndex=datacollect1-1-1-2-3&steplength=1-5000";
             string reqStrTest = "attrIndex=datacollect";
            reqStrTest = reqStrTest + model.GetLateIdStatus()[0] + "-";//方案
            reqStrTest = reqStrTest + model.GetHistoryrun()[0] + "-";// 运行次数
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1] + "-";//成员1
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1] + "-";//属性1
            reqStrTest = reqStrTest + model.getAssociatedAttibuteId() ;//属性2
            reqStrTest = reqStrTest + "&steplength=";
            reqStrTest = reqStrTest + model.getStartStep()+"-";
            reqStrTest = reqStrTest + model.getEndStep() ;
            Console.WriteLine("reqstrTest_" + reqStrTest);



            string co =service.HttpGet(simpLinearURL + reqStrTest);
            string[] coArr = co.Split('$');
            double[] result =new double[3];
            for (int i = 0; i < 3; i++)
            {
                result[i] = double.Parse(coArr[i]);
            }
            return result;
           
        }

        public void textboxClear()
        {
            this.XYInfoTextBox.Text = "";
            this.fomulationTextBox.Text = "";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            associatedZedForm.createZedPane2();
            //  
            string anoAttributeId = model.getAssociatedAttibuteId();
            string anoAttributeName = model.getAssociatedAttibuteName();
            string reqStr = "";//拼接请求字符串:方案名-运行次数-成员名-属性1（x)-属性二（y）……………………………………………………………………………………

            double[] results = getRelations(reqStr);
            if (results != null)
            {
                this.fomulationTextBox.Text = "Y=" + results[0] + "* X +" + results[2];
                List<string> str = model.GetLateNameStatus();

                this.XYInfoTextBox.Text = "Y:" + anoAttributeName+"-"+ anoAttributeId + "  X:" +str[2]; //不确定获取第一个属性*****************************
            }
            model.setlinearResults(results);
            agent.informZedGetCoff();
        }

        

    }
}
