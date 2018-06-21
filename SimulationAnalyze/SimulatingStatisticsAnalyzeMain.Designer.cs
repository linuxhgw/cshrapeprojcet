namespace Analysis
{
    partial class SimulatingStatisticsAnalyzeMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zedWndPanel = new System.Windows.Forms.Panel();
            this.simuStatisticsPanel = new System.Windows.Forms.Panel();
            this.caseInfoWndPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.zedWndPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.simuStatisticsPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.caseInfoWndPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // zedWndPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.zedWndPanel, 2);
            this.zedWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedWndPanel.Location = new System.Drawing.Point(3, 3);
            this.zedWndPanel.Name = "zedWndPanel";
            this.zedWndPanel.Size = new System.Drawing.Size(369, 216);
            this.zedWndPanel.TabIndex = 0;
            // 
            // simuStatisticsPanel
            // 
            this.simuStatisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simuStatisticsPanel.Location = new System.Drawing.Point(3, 225);
            this.simuStatisticsPanel.Name = "simuStatisticsPanel";
            this.simuStatisticsPanel.Size = new System.Drawing.Size(181, 68);
            this.simuStatisticsPanel.TabIndex = 1;
            // 
            // caseInfoWndPanel
            // 
            this.caseInfoWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseInfoWndPanel.Location = new System.Drawing.Point(190, 225);
            this.caseInfoWndPanel.Name = "caseInfoWndPanel";
            this.caseInfoWndPanel.Size = new System.Drawing.Size(182, 68);
            this.caseInfoWndPanel.TabIndex = 2;
            // 
            // SimulatingStatisticsAnalyzeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 296);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "SimulatingStatisticsAnalyzeMain";
            this.Text = "仿真时域分析";
            this.Load += new System.EventHandler(this.SimulatingStatisticsAnalyzeMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel zedWndPanel;
        private System.Windows.Forms.Panel simuStatisticsPanel;
        private System.Windows.Forms.Panel caseInfoWndPanel;
    }
}