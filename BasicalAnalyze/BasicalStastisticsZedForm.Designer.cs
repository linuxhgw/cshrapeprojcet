namespace Analysis
{
    partial class BasicalStastisticsZedForm
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
            BaseInitializeComponent();
            //
            // defaultButton
            // 
            this.defaultButton = new System.Windows.Forms.Button();

            this.defaultButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.defaultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultButton.Location = new System.Drawing.Point(669, 3);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(96, 23);
            this.defaultButton.TabIndex = 9;
            this.defaultButton.Text = "还原默认显示";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            this.GraphAtrributesPanel.Controls.Add(this.defaultButton);
            // 
            // redrawButton
            // 
            this.redrawButton = new System.Windows.Forms.Button();

            this.redrawButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.redrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redrawButton.Location = new System.Drawing.Point(769, 5);
            this.redrawButton.Name = "redrawButton";
            this.redrawButton.Size = new System.Drawing.Size(45, 23);
            this.redrawButton.TabIndex = 3;
            this.redrawButton.Text = "刷新";
            this.redrawButton.UseVisualStyleBackColor = true;
            this.redrawButton.Click += new System.EventHandler(this.redrawButton_Click);

            this.SetGraphBasicPanel.Controls.Add(this.redrawButton);
        }

        #endregion
        public System.Windows.Forms.Button redrawButton;
        public System.Windows.Forms.Button defaultButton;
    }
}