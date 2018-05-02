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
    public partial class SimulatingStatisticsAnalyzeMain : Form
    {
        public InteractiveAgent agent = InteractiveAgent.getInstance();
        private CaseInfoForm caseInfoWnd;
        private SimulatingStatisticsZedForm simulatingStatisticsZedForm;
        private SimulatingStatisticsForm simulatingStatisticsForm;

        public SimulatingStatisticsAnalyzeMain()
        {
            InitializeComponent();
        }

        private void SimulatingStatisticsAnalyzeMain_Load(object sender, EventArgs e)
        {

            simulatingStatisticsZedForm = new SimulatingStatisticsZedForm();
            agent.simulatingStatisticsZedForm = simulatingStatisticsZedForm;
            simulatingStatisticsZedForm.MdiParent = this;
            simulatingStatisticsZedForm.Dock = DockStyle.Fill;
            simulatingStatisticsZedForm.Parent = zedWndPanel;
            simulatingStatisticsZedForm.Show();

            simulatingStatisticsForm =new SimulatingStatisticsForm();
            agent.simulatingStatisticsForm = simulatingStatisticsForm;
            simulatingStatisticsForm.MdiParent = this;
            simulatingStatisticsForm.Dock = DockStyle.Fill;
            simulatingStatisticsForm.Parent = simuStatisticsPanel;
            simulatingStatisticsForm.Show();
            agent.simulatingStatisticsForm = simulatingStatisticsForm;

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
    }
}
