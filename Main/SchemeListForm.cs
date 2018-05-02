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

        public DataFromService service = new DataFromService();
        private ReqStr reqStr = ReqStr.getInstance();
        public string LoadFormula;
        public string LoadFormulaList1;
        public string param = "?schemeID=";

        TreeNode node1;//根节点

        private SchemeListForm()
        {
            InitializeComponent();
            reqStr.Url();
            LoadFormula = reqStr.LoadFormula1;
            LoadFormulaList1 = reqStr.LoadFormulaList1;


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

        public List<string> getSchemeFromService()
        {
            List<string> list = new List<string>();
            string result = service.HttpGet(LoadFormulaList1);
            string[] arrSchemeValue = result.Split(';');
            for (int i = 0; i + 1 < arrSchemeValue.Length; i = i + 1)
            {
                list.Add(arrSchemeValue[i]);
            }
            return list;
        }
        public List<string> getMemberFromService()
        {
            List<string> list = new List<string>();
            List<int> Listid = model.GetLateIdStatus();
            Console.WriteLine(LoadFormula + param + Listid[0]);
            string result = service.HttpGet(LoadFormula + param + Listid[0]);
            string[] arrSchemeValue = result.Split(';');
            for (int i = 0; i + 1 < arrSchemeValue.Length; i = i + 1)
            {
                list.Add(arrSchemeValue[i]);
                Console.WriteLine(arrSchemeValue[i]);
            }
            return list;
        }


        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                model.AddStatus(e.Node.FullPath);

                agent.SchemeToDataGraphic();
                agent.SchemeToAtrr();
                agent.SchemeToRecord();
                model.GetLateIdStatus();
                if (e.Node.Level == 1 && e.Node.LastNode == null)
                {
                    List<string> Memberlist = getMemberFromService();
                    for (int i = 0; i < Memberlist.Count; i++)
                    {
                        TreeNode temp = new TreeNode(Memberlist[i]);
                        e.Node.Nodes.Add(temp);
                        temp.Nodes.Add(new TreeNode(Memberlist[i]));
                    }
                }

                //  getjson getjson = new getjson();
                // getjson.getjson1();

                if (e.Node.Text.Equals("test-1"))
                {

                    agent.SchemeToRuntimes();
                }
            }
        }

        private void SchemeListForm_Load(object sender, EventArgs e)
        {

            node1 = treeView1.Nodes.Add("全部方案信息");
            for (int i = 0; i < getSchemeFromService().Count; i++)
            {
                node1.Nodes.Add(new TreeNode(getSchemeFromService()[i]));
            }




        }

    }
}