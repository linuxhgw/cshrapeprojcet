namespace Analysis
{
    partial class AsscociationAnalyzeMain
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.caseInfoWndPanel = new System.Windows.Forms.Panel();
            this.XYFomulationPanel = new System.Windows.Forms.Panel();
            this.fomulationTextBox = new System.Windows.Forms.TextBox();
            this.XYInfoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.XYFomulationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.zedWndPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.caseInfoWndPanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.XYFomulationPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.XYInfoTextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 332);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // zedWndPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.zedWndPanel, 3);
            this.zedWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedWndPanel.Location = new System.Drawing.Point(3, 3);
            this.zedWndPanel.Name = "zedWndPanel";
            this.zedWndPanel.Size = new System.Drawing.Size(371, 243);
            this.zedWndPanel.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultLabel.Location = new System.Drawing.Point(3, 283);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 16);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "结果";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 23);
            this.panel1.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "开始计算相关性";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // caseInfoWndPanel
            // 
            this.caseInfoWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseInfoWndPanel.Location = new System.Drawing.Point(190, 252);
            this.caseInfoWndPanel.Name = "caseInfoWndPanel";
            this.tableLayoutPanel1.SetRowSpan(this.caseInfoWndPanel, 3);
            this.caseInfoWndPanel.Size = new System.Drawing.Size(184, 77);
            this.caseInfoWndPanel.TabIndex = 6;
            // 
            // XYFomulationPanel
            // 
            this.XYFomulationPanel.Controls.Add(this.fomulationTextBox);
            this.XYFomulationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XYFomulationPanel.Location = new System.Drawing.Point(59, 281);
            this.XYFomulationPanel.Name = "XYFomulationPanel";
            this.XYFomulationPanel.Size = new System.Drawing.Size(125, 20);
            this.XYFomulationPanel.TabIndex = 7;
            // 
            // fomulationTextBox
            // 
            this.fomulationTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fomulationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fomulationTextBox.Location = new System.Drawing.Point(0, 0);
            this.fomulationTextBox.Name = "fomulationTextBox";
            this.fomulationTextBox.ReadOnly = true;
            this.fomulationTextBox.Size = new System.Drawing.Size(125, 21);
            this.fomulationTextBox.TabIndex = 7;
            // 
            // XYInfoTextBox
            // 
            this.XYInfoTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.XYInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XYInfoTextBox.Location = new System.Drawing.Point(59, 307);
            this.XYInfoTextBox.Name = "XYInfoTextBox";
            this.XYInfoTextBox.ReadOnly = true;
            this.XYInfoTextBox.Size = new System.Drawing.Size(125, 21);
            this.XYInfoTextBox.TabIndex = 8;
            // 
            // AsscociationAnalyzeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 332);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "AsscociationAnalyzeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AsscociationAnalyzeMain";
            this.Load += new System.EventHandler(this.AsscociationAnalyzeMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.XYFomulationPanel.ResumeLayout(false);
            this.XYFomulationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel zedWndPanel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel caseInfoWndPanel;
        private System.Windows.Forms.Panel XYFomulationPanel;
        private System.Windows.Forms.TextBox XYInfoTextBox;
        private System.Windows.Forms.TextBox fomulationTextBox;
        private System.Windows.Forms.Button startButton;

    }
}