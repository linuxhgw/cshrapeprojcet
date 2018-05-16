namespace Analysis
{
    partial class CaseInfoForm
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
            this.caseInfoListView = new Analysis.ListViewEx();
            this.caseInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // caseInfoListView
            // 
            this.caseInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.caseInfo,
            this.Info});
            this.caseInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseInfoListView.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.caseInfoListView.GridLines = true;
            this.caseInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.caseInfoListView.Location = new System.Drawing.Point(0, 0);
            this.caseInfoListView.Name = "caseInfoListView";
            this.caseInfoListView.Size = new System.Drawing.Size(167, 139);
            this.caseInfoListView.TabIndex = 0;
            this.caseInfoListView.UseCompatibleStateImageBehavior = false;
            this.caseInfoListView.View = System.Windows.Forms.View.Details;
            this.caseInfoListView.MouseHover += new System.EventHandler(this.caseInfoListView_MouseHover);
            this.caseInfoListView.Resize += new System.EventHandler(this.listView1_Resize);
            // 
            // caseInfo
            // 
            this.caseInfo.Text = "方案信息";
            this.caseInfo.Width = 82;
            // 
            // Info
            // 
            this.Info.Text = "";
            this.Info.Width = 222;
            // 
            // CaseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 139);
            this.ControlBox = false;
            this.Controls.Add(this.caseInfoListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaseInfoForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListViewEx caseInfoListView;
        private System.Windows.Forms.ColumnHeader caseInfo;
        private System.Windows.Forms.ColumnHeader Info;
    }
}