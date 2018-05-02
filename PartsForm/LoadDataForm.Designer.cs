namespace Analysis.PartsForm
{
    partial class LoadDataForm
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
            this.loadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.dynamicaRadioButton = new System.Windows.Forms.RadioButton();
            this.staticLoadRadioButton = new System.Windows.Forms.RadioButton();
            this.confirmLoadButton = new System.Windows.Forms.Button();
            this.cancleLoadbutton = new System.Windows.Forms.Button();
            this.loadDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadDataGroupBox
            // 
            this.loadDataGroupBox.Controls.Add(this.dynamicaRadioButton);
            this.loadDataGroupBox.Controls.Add(this.staticLoadRadioButton);
            this.loadDataGroupBox.Location = new System.Drawing.Point(-3, 1);
            this.loadDataGroupBox.Name = "loadDataGroupBox";
            this.loadDataGroupBox.Size = new System.Drawing.Size(316, 56);
            this.loadDataGroupBox.TabIndex = 0;
            this.loadDataGroupBox.TabStop = false;
            this.loadDataGroupBox.Text = "载入方式";
            // 
            // dynamicaRadioButton
            // 
            this.dynamicaRadioButton.AutoSize = true;
            this.dynamicaRadioButton.Location = new System.Drawing.Point(205, 24);
            this.dynamicaRadioButton.Name = "dynamicaRadioButton";
            this.dynamicaRadioButton.Size = new System.Drawing.Size(71, 16);
            this.dynamicaRadioButton.TabIndex = 1;
            this.dynamicaRadioButton.TabStop = true;
            this.dynamicaRadioButton.Text = "动态载入";
            this.dynamicaRadioButton.UseVisualStyleBackColor = true;
            this.dynamicaRadioButton.CheckedChanged += new System.EventHandler(this.dynamicaRadioButton_CheckedChanged);
            // 
            // staticLoadRadioButton
            // 
            this.staticLoadRadioButton.AutoSize = true;
            this.staticLoadRadioButton.Location = new System.Drawing.Point(43, 24);
            this.staticLoadRadioButton.Name = "staticLoadRadioButton";
            this.staticLoadRadioButton.Size = new System.Drawing.Size(71, 16);
            this.staticLoadRadioButton.TabIndex = 0;
            this.staticLoadRadioButton.TabStop = true;
            this.staticLoadRadioButton.Text = "静态载入";
            this.staticLoadRadioButton.UseVisualStyleBackColor = true;
            this.staticLoadRadioButton.CheckedChanged += new System.EventHandler(this.staticLoadRadioButton_CheckedChanged);
            // 
            // confirmLoadButton
            // 
            this.confirmLoadButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmLoadButton.Location = new System.Drawing.Point(38, 72);
            this.confirmLoadButton.Name = "confirmLoadButton";
            this.confirmLoadButton.Size = new System.Drawing.Size(75, 23);
            this.confirmLoadButton.TabIndex = 1;
            this.confirmLoadButton.Text = "确定";
            this.confirmLoadButton.UseVisualStyleBackColor = true;
            // 
            // cancleLoadbutton
            // 
            this.cancleLoadbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancleLoadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancleLoadbutton.Location = new System.Drawing.Point(208, 72);
            this.cancleLoadbutton.Name = "cancleLoadbutton";
            this.cancleLoadbutton.Size = new System.Drawing.Size(75, 23);
            this.cancleLoadbutton.TabIndex = 2;
            this.cancleLoadbutton.Text = "取消";
            this.cancleLoadbutton.UseVisualStyleBackColor = true;
            // 
            // LoadDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(312, 107);
            this.ControlBox = false;
            this.Controls.Add(this.cancleLoadbutton);
            this.Controls.Add(this.confirmLoadButton);
            this.Controls.Add(this.loadDataGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoadDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "载入数据";
            this.loadDataGroupBox.ResumeLayout(false);
            this.loadDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loadDataGroupBox;
        private System.Windows.Forms.RadioButton dynamicaRadioButton;
        private System.Windows.Forms.RadioButton staticLoadRadioButton;
        private System.Windows.Forms.Button confirmLoadButton;
        private System.Windows.Forms.Button cancleLoadbutton;
    }
}