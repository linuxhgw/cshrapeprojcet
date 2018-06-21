using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis.Classify
{
    public partial class ClassifyMain : Form
    {
          private CaseInfoForm caseInfoWnd;
         public SchemeModel model = SchemeModel.getInstance();
        private ReqStr reqStr = ReqStr.getInstance();
         private string LinearBackURL ;
        //attrId=datacollect0-3-1-3&steplength=1-5000";
        public string LoadFormula ;
        public string param = "?schemeID=";

        public DataFromService service = new DataFromService();
        public ClassifyMain()
        {
            InitializeComponent();
            reqStr.Url();
            LinearBackURL = reqStr.LinearBackURL1;
            LoadFormula = reqStr.LoadFormula1;

        }
        private void LinearBackAnalyzeMain_Load(object sender, EventArgs e)
        {
            caseInfoWnd = new CaseInfoForm();
            caseInfoWnd.MdiParent = this;
            caseInfoWnd.Dock = DockStyle.Fill;
            caseInfoWnd.Parent = caseInfoWndPanel;
            caseInfoWnd.Show();
            setBasicalDataAnalyzeMainSize();
        }


        public List<string> getMemberFromService()
        {
            List<string> list = new List<string>();
            List<int> Listid = model.GetLateIdStatus();
            Console.WriteLine(LoadFormula+ param + Listid[0]);
            string result = service.HttpGet(LoadFormula + param + Listid[0]);
            string[] arrSchemeValue = result.Split(';');
            for (int i = 0; i + 1 < arrSchemeValue.Length; i = i + 1)
            {
                list.Add(arrSchemeValue[i]);
                Console.WriteLine(arrSchemeValue[i]);
            }
            return list;
        }
        //------------------------------------------
        public void setBasicalDataAnalyzeMainSize()
        {
            Rectangle screenArea = System.Windows.Forms.Screen.GetBounds(this);
            this.Width = screenArea.Width / 2;
            this.Height = screenArea.Height / 2;
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;
            int yHeight = SystemInformation.PrimaryMonitorSize.Height;
            this.Location = new Point((xWidth - this.Width) / 2, (yHeight - this.Height) / 2);
        }

        //开始调用服务进行线性回归分析…………………………………………………………………………………………………………………………
        private void startButton_Click(object sender, EventArgs e)

        {

            this.resultRichTextBox.Text = "分类分析结果展示……\n";

            List<string> reqRecord=model.GetLateNameStatus();
            string reqAttr=reqRecord[2];
            double temp;
            int i;
            string reqStr = "attrId=datacollect1-1-1-3&steplength=1-2000";//请求服务字符串：方案名-运行次数-成员-属性
            string reqStrTest = "attrId=datacollect";
            reqStrTest = reqStrTest + model.GetLateIdStatus()[0] + "-";//方案
            reqStrTest = reqStrTest + model.GetHistoryrun()[0] + "-";// 运行次数
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1] + "-";//成员1
            reqStrTest = reqStrTest + model.GetLateIdStatus()[1]  ;//属性1

            reqStrTest = reqStrTest + "&steplength=";
            reqStrTest = reqStrTest + model.getStartStep() + "-";
            reqStrTest = reqStrTest + model.getEndStep() ;
            Console.WriteLine("reqstrTest_____" + reqStrTest);


            System.DateTime beforeTime = System.DateTime.Now;
            string result = service.HttpGet(LinearBackURL + reqStrTest);
            string[] results = result.Split('$');
            //获取成员下所有属性，
            //List<string> restAttr=model.getMemberAttrbutes();
           
            List<string> restAttrTest = getMemberFromService();

           //………………………………………………………………………………………………………………………………………………………………………………………………………………
            if(results==null)
            {
                this.resultRichTextBox.AppendText("Linear Regression Model\n"+"no model!");
                return ;
            }
           List<string> list = new List<string>();
            list.Add("Linear Regression Model\n");
            list.Add(reqAttr + "=\n");
             for ( i= 0; i < results.Length-2; i++)
            {
                temp=Double.Parse(results[i]);
                if(temp!=0.0)
                {
                    list.Add("\t\t+("+restAttrTest[i]+")*"+results[i]+"\n");
                }
                //
            }
            list.Add("\t\t"+results[i]+"\n");//常系数

            for(i=0;i<list.Count;i++)
            {
                this.resultRichTextBox.AppendText(list[i]);
            }
            System.DateTime afterTime = System.DateTime.Now;
            TimeSpan ts = afterTime.Subtract(beforeTime);
            this.wasteTimeTextBox.Text = ts.TotalMilliseconds + "mm";
        }

       

        //保存分析文件----------------------------------------
        private void savaButton_Click(object sender, EventArgs e)
        {
            if (resultRichTextBox.Text == "")
            {
                return;
            }
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = this.saveFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                this.resultRichTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("文件已成功保存");
            }
        }
    }
}
