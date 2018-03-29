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
          private string LinearBackURL = "http://stuzhou:5555/api-analysis/getLinearRegressionResult?";
              //attrId=datacollect0-3-1-3&steplength=1-5000";
        public DataFromService service = new DataFromService();
        public ClassifyMain()
        {
            InitializeComponent();
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
            List<string> reqRecord=model.GetLateNameStatus();
            string reqAttr=reqRecord[2];
            double temp;
            int i;
            string reqStr = "attrId=datacollect0-3-1-3&steplength=1-5000";//请求服务字符串：方案名-运行次数-成员-属性
            System.DateTime beforeTime = System.DateTime.Now;
            string result = service.HttpGet(LinearBackURL + reqStr);
            string[] results = result.Split('$');
            //获取成员下所有属性，
           // List<string> restAttr=model.getMemberAttrbutes();
            List<string> restAttr=new List<string>{"属性一","属性二"};
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
                    list.Add("\t\t+("+restAttr[i]+")*"+results[i]+"\n");
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
