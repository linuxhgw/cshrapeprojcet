namespace Analysis
{
    partial class DigAssociationAnalyzeMain
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
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultRichTextBox = new Analysis.RichTextBoxEx();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.caseInfoWndPanel = new System.Windows.Forms.Panel();
            this.wasteTime = new System.Windows.Forms.Label();
            this.wasteTimeTextBox = new System.Windows.Forms.TextBox();
            this.savaButtonPanel = new System.Windows.Forms.Panel();
            this.savaButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.savaButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.resultPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.caseInfoWndPanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.wasteTime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.wasteTimeTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.savaButtonPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.SetColumnSpan(this.resultPanel, 3);
            this.resultPanel.Controls.Add(this.resultRichTextBox);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(3, 3);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(382, 255);
            this.resultPanel.TabIndex = 0;
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.resultRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultRichTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(382, 255);
            this.resultRichTextBox.TabIndex = 0;
            this.resultRichTextBox.Text = "关联分析结果展示……";
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 25);
            this.panel2.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(187, 25);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "开始关联分析";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // caseInfoWndPanel
            // 
            this.caseInfoWndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseInfoWndPanel.Location = new System.Drawing.Point(196, 264);
            this.caseInfoWndPanel.Name = "caseInfoWndPanel";
            this.tableLayoutPanel1.SetRowSpan(this.caseInfoWndPanel, 3);
            this.caseInfoWndPanel.Size = new System.Drawing.Size(189, 82);
            this.caseInfoWndPanel.TabIndex = 2;
            // 
            // wasteTime
            // 
            this.wasteTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wasteTime.AutoSize = true;
            this.wasteTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wasteTime.Location = new System.Drawing.Point(3, 323);
            this.wasteTime.Name = "wasteTime";
            this.wasteTime.Size = new System.Drawing.Size(40, 26);
            this.wasteTime.TabIndex = 3;
            this.wasteTime.Text = "耗时：";
            // 
            // wasteTimeTextBox
            // 
            this.wasteTimeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wasteTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wasteTimeTextBox.Location = new System.Drawing.Point(61, 326);
            this.wasteTimeTextBox.Name = "wasteTimeTextBox";
            this.wasteTimeTextBox.ReadOnly = true;
            this.wasteTimeTextBox.Size = new System.Drawing.Size(129, 21);
            this.wasteTimeTextBox.TabIndex = 5;
            // 
            // savaButtonPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.savaButtonPanel, 2);
            this.savaButtonPanel.Controls.Add(this.savaButton);
            this.savaButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savaButtonPanel.Location = new System.Drawing.Point(3, 295);
            this.savaButtonPanel.Name = "savaButtonPanel";
            this.savaButtonPanel.Size = new System.Drawing.Size(187, 25);
            this.savaButtonPanel.TabIndex = 6;
            // 
            // savaButton
            // 
            this.savaButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savaButton.Location = new System.Drawing.Point(0, 0);
            this.savaButton.Name = "savaButton";
            this.savaButton.Size = new System.Drawing.Size(187, 25);
            this.savaButton.TabIndex = 0;
            this.savaButton.Text = "保存";
            this.savaButton.UseVisualStyleBackColor = false;
            this.savaButton.Click += new System.EventHandler(this.savaButton_Click);
            // 
            // DigAssociationAnalyzeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "DigAssociationAnalyzeMain";
            this.Text = "挖掘算法之平凡项集";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DigAssociationAnalyzeMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.savaButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel caseInfoWndPanel;
        private System.Windows.Forms.Label wasteTime;
        private System.Windows.Forms.TextBox wasteTimeTextBox;
        private RichTextBoxEx resultRichTextBox;
        private System.Windows.Forms.Panel savaButtonPanel;
        private System.Windows.Forms.Button savaButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;


    }
}