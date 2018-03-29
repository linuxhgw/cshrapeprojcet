namespace Analysis
{
    partial class BasicalStastisticsForm
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
            this.staWndListview = new Analysis.ListViewEx();
            this.staNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // staWndListview
            // 
            this.staWndListview.CheckBoxes = true;
            this.staWndListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.staNames,
            this.value});
            this.staWndListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staWndListview.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staWndListview.GridLines = true;
            this.staWndListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.staWndListview.Location = new System.Drawing.Point(0, 0);
            this.staWndListview.Name = "staWndListview";
            this.staWndListview.Size = new System.Drawing.Size(162, 195);
            this.staWndListview.TabIndex = 0;
            this.staWndListview.UseCompatibleStateImageBehavior = false;
            this.staWndListview.View = System.Windows.Forms.View.Details;
            this.staWndListview.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.staWndListview.Resize += new System.EventHandler(this.listView1_Resize);
            // 
            // staNames
            // 
            this.staNames.Text = "统计值";
            this.staNames.Width = 71;
            // 
            // value
            // 
            this.value.Text = "值";
            this.value.Width = 222;
            // 
            // BasicalStastisticsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(162, 195);
            this.ControlBox = false;
            this.Controls.Add(this.staWndListview);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BasicalStastisticsForm";
            this.Text = "数据分析";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader staNames;
        private System.Windows.Forms.ColumnHeader value;
        private ListViewEx staWndListview;

    }

}