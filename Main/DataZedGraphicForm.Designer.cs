namespace Analysis
{
    partial class DataZedGraphicForm
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.endStepTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startStepTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.IsAutoScrollRange = true;
            this.zedGraphControl1.IsEnableHZoom = false;
            this.zedGraphControl1.IsEnableVZoom = false;
            this.zedGraphControl1.IsShowHScrollBar = true;
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.IsShowVScrollBar = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 35);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(817, 435);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.endStepTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.startStepTextBox);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 37);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(716, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "更改步长";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "区间段";
            // 
            // endStepTextBox
            // 
            this.endStepTextBox.Location = new System.Drawing.Point(254, 7);
            this.endStepTextBox.Name = "endStepTextBox";
            this.endStepTextBox.Size = new System.Drawing.Size(100, 21);
            this.endStepTextBox.TabIndex = 2;
            this.endStepTextBox.Text = "50";
            this.endStepTextBox.TextChanged += new System.EventHandler(this.endStepTextBox_TextChanged);
            this.endStepTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.endStepTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(204, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "~";
            // 
            // startStepTextBox
            // 
            this.startStepTextBox.Location = new System.Drawing.Point(98, 7);
            this.startStepTextBox.Name = "startStepTextBox";
            this.startStepTextBox.Size = new System.Drawing.Size(100, 21);
            this.startStepTextBox.TabIndex = 0;
            this.startStepTextBox.Text = "1";
            this.startStepTextBox.TextChanged += new System.EventHandler(this.startStepTextBox_TextChanged);
            this.startStepTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startStepTextBox_KeyDown);
            // 
            // DataZedGraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zedGraphControl1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DataZedGraphicForm";
            this.Text = "图示";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox endStepTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startStepTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}