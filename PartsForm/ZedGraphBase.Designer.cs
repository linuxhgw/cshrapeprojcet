﻿namespace Analysis
{
    partial class ZedGraphBase
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
        public void BaseInitializeComponent()
        {
            this.SetGraphBasicPanel = new System.Windows.Forms.Panel();
            this.intervelLabel = new System.Windows.Forms.Label();
            this.stepToTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.stepFromTextBox = new System.Windows.Forms.TextBox();
            this.isGridCheckBox = new System.Windows.Forms.CheckBox();
            this.ZedBottomPanel = new System.Windows.Forms.Panel();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.GraphAtrributesPanel = new System.Windows.Forms.Panel();
            this.lineColorLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.SetGraphBasicPanel.SuspendLayout();
            this.ZedBottomPanel.SuspendLayout();
            this.GraphAtrributesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetGraphBasicPanel
            // 
            this.SetGraphBasicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SetGraphBasicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SetGraphBasicPanel.Controls.Add(this.intervelLabel);
            this.SetGraphBasicPanel.Controls.Add(this.stepToTextBox);
            this.SetGraphBasicPanel.Controls.Add(this.toLabel);
            this.SetGraphBasicPanel.Controls.Add(this.stepFromTextBox);
            this.SetGraphBasicPanel.Location = new System.Drawing.Point(0, 28);
            this.SetGraphBasicPanel.Name = "SetGraphBasicPanel";
            this.SetGraphBasicPanel.Size = new System.Drawing.Size(817, 37);
            this.SetGraphBasicPanel.TabIndex = 1;
            // 
            // intervelLabel
            // 
            this.intervelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.intervelLabel.AutoSize = true;
            this.intervelLabel.Location = new System.Drawing.Point(13, 10);
            this.intervelLabel.Name = "intervelLabel";
            this.intervelLabel.Size = new System.Drawing.Size(41, 12);
            this.intervelLabel.TabIndex = 4;
            this.intervelLabel.Text = "区间段";
            // 
            // stepFromTextBox
            // 
            this.stepFromTextBox.Location = new System.Drawing.Point(73, 7);
            this.stepFromTextBox.Name = "stepToTextBox";
            this.stepFromTextBox.Size = new System.Drawing.Size(100, 21);
            this.stepFromTextBox.TabIndex = 2;
            this.stepFromTextBox.Text = "1";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toLabel.Location = new System.Drawing.Point(172, 13);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(44, 48);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "~";
            // 
            // stepToTextBox
            // 
            this.stepToTextBox.Location = new System.Drawing.Point(216, 8);
            this.stepToTextBox.Name = "stepFromTextBox";
            this.stepToTextBox.Size = new System.Drawing.Size(100, 21);
            this.stepToTextBox.Text = "100";
            //
            // defaultButton
            // 

            this.stepFromTextBox.TabIndex = 0;

            // 
            // isGridCheckBox
            // 
            this.isGridCheckBox.AutoSize = true;
            this.isGridCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.isGridCheckBox.Location = new System.Drawing.Point(769, 0);
            this.isGridCheckBox.Name = "isGridCheckBox";
            this.isGridCheckBox.Size = new System.Drawing.Size(48, 30);
            this.isGridCheckBox.TabIndex = 6;
            this.isGridCheckBox.Text = "网格";
            this.isGridCheckBox.UseVisualStyleBackColor = true;
            this.isGridCheckBox.CheckedChanged += new System.EventHandler(this.isGridCheckBox_CheckedChanged);
            // 
            // ZedBottomPanel
            // 
            this.ZedBottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ZedBottomPanel.AutoScroll = true;
            this.ZedBottomPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ZedBottomPanel.Controls.Add(this.zedGraphControl);
            this.ZedBottomPanel.Location = new System.Drawing.Point(0, 62);
            this.ZedBottomPanel.Name = "ZedBottomPanel";
            this.ZedBottomPanel.Size = new System.Drawing.Size(817, 402);
            this.ZedBottomPanel.TabIndex = 2;
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl.IsEnableVZoom = false;
            this.zedGraphControl.IsShowHScrollBar = true;
            this.zedGraphControl.IsShowPointValues = true;
            this.zedGraphControl.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(817, 402);
            this.zedGraphControl.TabIndex = 1;
            // 
            // GraphAtrributesPanel
            // 
            this.GraphAtrributesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphAtrributesPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.GraphAtrributesPanel.Controls.Add(this.lineColorLabel);
            this.GraphAtrributesPanel.Controls.Add(this.isGridCheckBox);
            this.GraphAtrributesPanel.Controls.Add(this.colorComboBox);

            this.GraphAtrributesPanel.Location = new System.Drawing.Point(0, 0);
            this.GraphAtrributesPanel.Name = "GraphAtrributesPanel";
            this.GraphAtrributesPanel.Size = new System.Drawing.Size(817, 30);
            this.GraphAtrributesPanel.TabIndex = 3;
            this.GraphAtrributesPanel.MouseEnter += new System.EventHandler(this.GraphAtrributesPanel_MouseEnter);
            // 
            // lineColorLabel
            // 
            this.lineColorLabel.AutoSize = true;
            this.lineColorLabel.Location = new System.Drawing.Point(13, 9);
            this.lineColorLabel.Name = "lineColorLabel";
            this.lineColorLabel.Size = new System.Drawing.Size(53, 12);
            this.lineColorLabel.TabIndex = 7;
            this.lineColorLabel.Text = "线条颜色";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "黑色",
            "绿色",
            "蓝色",
            "红色",
            "粉色",
            "更多……"});
            this.colorComboBox.Location = new System.Drawing.Point(72, 5);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 20);
            this.colorComboBox.TabIndex = 0;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // ZedGraphBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 464);
            this.ControlBox = false;
            this.Controls.Add(this.GraphAtrributesPanel);
            this.Controls.Add(this.ZedBottomPanel);
            this.Controls.Add(this.SetGraphBasicPanel);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZedGraphBase";
            this.Text = "ResultForm";
            this.SetGraphBasicPanel.ResumeLayout(false);
            this.SetGraphBasicPanel.PerformLayout();
            this.ZedBottomPanel.ResumeLayout(false);
            this.GraphAtrributesPanel.ResumeLayout(false);
            this.GraphAtrributesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel SetGraphBasicPanel;
        public System.Windows.Forms.TextBox stepToTextBox;
        private System.Windows.Forms.Label toLabel;
        public System.Windows.Forms.TextBox stepFromTextBox;
        private System.Windows.Forms.Label intervelLabel;
        private System.Windows.Forms.Panel ZedBottomPanel;
        public ZedGraph.ZedGraphControl zedGraphControl;
        protected System.Windows.Forms.Panel GraphAtrributesPanel;
        private System.Windows.Forms.CheckBox isGridCheckBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label lineColorLabel;

    }
}