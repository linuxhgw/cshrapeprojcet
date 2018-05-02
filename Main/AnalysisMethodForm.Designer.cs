namespace Analysis {
    partial class AnalysisMethodForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("基本分析");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("简单线性回归");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("基本分析方法", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("关联");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("分类");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("聚合");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("决策树");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("挖掘算法", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("时域分析");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("仿真时域分析", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("分析方法", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode10});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "基本分析";
            treeNode2.Name = "节点1";
            treeNode2.Text = "简单线性回归";
            treeNode3.Name = "basicalAnalyzeTreeNode";
            treeNode3.Text = "基本分析方法";
            treeNode4.Name = "节点2";
            treeNode4.Text = "关联";
            treeNode5.Name = "节点3";
            treeNode5.Text = "分类";
            treeNode6.Name = "节点0";
            treeNode6.Text = "聚合";
            treeNode7.Name = "节点3";
            treeNode7.Text = "决策树";
            treeNode8.Name = "associatedAnalyzeTreeNode";
            treeNode8.Text = "挖掘算法";
            treeNode9.Name = "节点4";
            treeNode9.Text = "时域分析";
            treeNode10.Name = "timeAnalyzeTreeNode";
            treeNode10.Text = "仿真时域分析";
            treeNode11.Name = "analyzeMethods";
            treeNode11.Text = "分析方法";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(190, 290);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // AnalysisMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 290);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AnalysisMethodForm";
            this.Text = "分析方法";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}