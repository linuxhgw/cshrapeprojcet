using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Analysis
{
    public partial class BasicalDataAnalyzeMain : Form
    {
        private CaseInfoForm caseInfoWnd;
        private BasicalStastisticsForm basicalStastiticWnd;
        private BasicalStastisticsZedForm basicalStastisticsZedWnd;
        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public BasicalDataAnalyzeMain()
        {
            InitializeComponent();
        }

        //加载子窗体
        private void BasicalDataAnalyzeMain_Load(object sender, EventArgs e)
        {

            basicalStastisticsZedWnd = new BasicalStastisticsZedForm();
            agent.basicalStastisticsZedForm = basicalStastisticsZedWnd;
            basicalStastisticsZedWnd.MdiParent = this;
            basicalStastisticsZedWnd.Dock = DockStyle.Fill;
            basicalStastisticsZedWnd.Parent = zedWndPanel;
            basicalStastisticsZedWnd.Show();

            basicalStastiticWnd = new BasicalStastisticsForm();
            agent.basicalStastiticWnd = basicalStastiticWnd;
            basicalStastiticWnd.MdiParent = this;
            basicalStastiticWnd.Dock = DockStyle.Fill;
            basicalStastiticWnd.Parent = staWndPanel;
            basicalStastiticWnd.Show();


            caseInfoWnd = new CaseInfoForm();
            caseInfoWnd.MdiParent = this;
            caseInfoWnd.Dock = DockStyle.Fill;
            caseInfoWnd.Parent = caseInfoWndPanel;
            caseInfoWnd.Show();


            setBasicalDataAnalyzeMainSize();
        }

        //设置窗体在屏幕的位置和大小
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
    }
}
