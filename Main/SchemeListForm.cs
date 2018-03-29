using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis {
    public partial class SchemeListForm : WeifenLuo.WinFormsUI.Docking.DockContent {


        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();

        TreeNode node1;//根节点

        private SchemeListForm()
        {
            InitializeComponent();
        }

        //二.声明一个字窗体的类型的静态变量  
        private static SchemeListForm instance;

        //三.通过静态方法创建字窗体  
        public static SchemeListForm CreateFrom()
        {
            //判断是否存在该窗体,或时候该字窗体是否被释放过,如果不存在该窗体,则 new 一个字窗体  
            if (instance == null || instance.IsDisposed)
            {
                instance = new SchemeListForm();
            }
            return instance;
        }
        public TreeNode Tree() {

            TreeNode node1 = new TreeNode("(001)方案一");

            TreeNode node2 = new TreeNode("(002)成员1");
            TreeNode node3 = new TreeNode("(003)成员2");
            TreeNode node4 = new TreeNode("(004)成员3");
            node1.Nodes.Add(node2);
            node1.Nodes.Add(node3);
            node1.Nodes.Add(node4);


            TreeNode node5 = new TreeNode("(005)属性1");
            TreeNode node6 = new TreeNode("(006)属性2");
            TreeNode node7 = new TreeNode("(007)属性1");
            TreeNode node8 = new TreeNode("(008)属性2");
            TreeNode node9 = new TreeNode("(009)属性1");
            TreeNode node0 = new TreeNode("(000)属性2");
            node2.Nodes.Add(node5);
            node2.Nodes.Add(node6);
            node3.Nodes.Add(node7);
            node3.Nodes.Add(node8);
            node4.Nodes.Add(node9);
            node4.Nodes.Add(node0);
           
            return node1;
        }   //方案信息

        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                model.AddStatus(e.Node.FullPath);
           
                agent.SchemeToDataGraphic();
                agent.SchemeToAtrr();
                agent.SchemeToRecord();
                model.GetLateIdStatus();

              //  getjson getjson = new getjson();
               // getjson.getjson1();

                if (e.Node.Text.Equals("(001)方案一")) {
                    
                    agent.SchemeToRuntimes();
                }
            }
        }

        private void SchemeListForm_Load(object sender, EventArgs e) {

            node1 = treeView1.Nodes.Add("全部方案信息");
            node1.Nodes.Add(Tree());
            node1.ExpandAll();
           


        }

    }
}
