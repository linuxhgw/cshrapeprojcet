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
    public partial class DigAssociationAnalyzeMain : Form
    {

        private CaseInfoForm caseInfoWnd;
        private ReqStr requeststring  =ReqStr.getInstance();

        private string aprioriURL;
        private string aprioriURLTest;

        public DataFromService service = new DataFromService();


        public DigAssociationAnalyzeMain()
        {
            InitializeComponent();
            requeststring.Url();
            aprioriURL = requeststring.AprioriURL;
        }

        private void DigAssociationAnalyzeMain_Load(object sender, EventArgs e)
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

        //开始调用服务进行关联分析…………………………………………………………………………………………………………………………
        private void startButton_Click(object sender, EventArgs e)
        {
            string reqStr = "tb_contact_lenses";//请求服务字符串：方案名
            System.DateTime beforeTime = System.DateTime.Now;
            string result = service.HttpGet(aprioriURL + reqStr);
            string[] results = result.Split('$');
            for (int i = 0; i < results.Length; i++)
            {
                this.resultRichTextBox.AppendText(results[i] + "\n");
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
