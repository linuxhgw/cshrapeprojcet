namespace Analysis
{
    partial class AssociatedAtrributionForm
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
            this.chosenAttributeListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.comfirmPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.comfirmButton = new System.Windows.Forms.Button();
            this.attributesListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.comfirmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.Controls.Add(this.chosenAttributeListBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comfirmPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.attributesListBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chosenAttributeListBox
            // 
            this.chosenAttributeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chosenAttributeListBox.FormattingEnabled = true;
            this.chosenAttributeListBox.ItemHeight = 16;
            this.chosenAttributeListBox.Location = new System.Drawing.Point(232, 4);
            this.chosenAttributeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.chosenAttributeListBox.Name = "chosenAttributeListBox";
            this.chosenAttributeListBox.Size = new System.Drawing.Size(133, 295);
            this.chosenAttributeListBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(144, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 295);
            this.panel1.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(0, 181);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 25);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "<<";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(0, 114);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 25);
            this.addButton.TabIndex = 0;
            this.addButton.Text = ">>";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // comfirmPanel
            // 
            this.comfirmPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.comfirmPanel, 3);
            this.comfirmPanel.Controls.Add(this.cancelButton);
            this.comfirmPanel.Controls.Add(this.comfirmButton);
            this.comfirmPanel.Location = new System.Drawing.Point(3, 306);
            this.comfirmPanel.Name = "comfirmPanel";
            this.comfirmPanel.Size = new System.Drawing.Size(363, 48);
            this.comfirmPanel.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(223, 11);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // comfirmButton
            // 
            this.comfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comfirmButton.Location = new System.Drawing.Point(22, 11);
            this.comfirmButton.Name = "comfirmButton";
            this.comfirmButton.Size = new System.Drawing.Size(118, 28);
            this.comfirmButton.TabIndex = 0;
            this.comfirmButton.Text = "确定";
            this.comfirmButton.UseVisualStyleBackColor = true;
            this.comfirmButton.Click += new System.EventHandler(this.comfirmButton_Click);
            // 
            // attributesListBox
            // 
            this.attributesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributesListBox.FormattingEnabled = true;
            this.attributesListBox.ItemHeight = 16;
            this.attributesListBox.Location = new System.Drawing.Point(3, 3);
            this.attributesListBox.Name = "attributesListBox";
            this.attributesListBox.Size = new System.Drawing.Size(134, 297);
            this.attributesListBox.TabIndex = 4;
            // 
            // AssociatedAtrributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 357);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssociatedAtrributionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关联属性";
            this.Load += new System.EventHandler(this.AssociatedAtrributionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.comfirmPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox chosenAttributeListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel comfirmPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox attributesListBox;
        private System.Windows.Forms.Button comfirmButton;

    }
}