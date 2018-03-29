namespace Analysis
{
    partial class BasicalDataAnalyzeMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zedWndPanel = new System.Windows.Forms.Panel();
            this.staWndPanel = new System.Windows.Forms.Panel();
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
            this.tableLayoutPanel1.Controls.Add(this.staWndPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.caseInfoWndPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 433);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // zedWndPanel
            // 
            this.zedWndPanel.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel1.SetColumnSpan(this.zedWndPanel, 2);
            this.zedWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedWndPanel.Location = new System.Drawing.Point(3, 3);
            this.zedWndPanel.Name = "zedWndPanel";
            this.zedWndPanel.Size = new System.Drawing.Size(684, 318);
            this.zedWndPanel.TabIndex = 0;
            // 
            // staWndPanel
            // 
            this.staWndPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.staWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staWndPanel.Location = new System.Drawing.Point(3, 327);
            this.staWndPanel.Name = "staWndPanel";
            this.staWndPanel.Size = new System.Drawing.Size(339, 103);
            this.staWndPanel.TabIndex = 1;
            // 
            // caseInfoWndPanel
            // 
            this.caseInfoWndPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.caseInfoWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseInfoWndPanel.Location = new System.Drawing.Point(348, 327);
            this.caseInfoWndPanel.Name = "caseInfoWndPanel";
            this.caseInfoWndPanel.Size = new System.Drawing.Size(339, 103);
            this.caseInfoWndPanel.TabIndex = 2;
            // 
            // BasicalDataAnalyzeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.IsMdiContainer = true;
            this.Name = "BasicalDataAnalyzeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基本数据分析";
            this.Load += new System.EventHandler(this.BasicalDataAnalyzeMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel zedWndPanel;
        private System.Windows.Forms.Panel staWndPanel;
        private System.Windows.Forms.Panel caseInfoWndPanel;



    }
}

