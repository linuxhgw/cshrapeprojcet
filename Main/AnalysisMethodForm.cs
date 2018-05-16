using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Analysis.Classify;
namespace Analysis {
    public partial class AnalysisMethodForm : WeifenLuo.WinFormsUI.Docking.DockContent {
        SchemeModel model = SchemeModel.getInstance();
        InteractiveAgent agent = InteractiveAgent.getInstance();
        const int WS_EX_NOACTIVATE = 0x08000000; 
        private AnalysisMethodForm()
        {
            InitializeComponent();
        }

        //二.声明一个字窗体的类型的静态变量  
        private static AnalysisMethodForm instance;

        //三.通过静态方法创建字窗体  
        public static AnalysisMethodForm CreateFrom()
        {
            //判断是否存在该窗体,或时候该字窗体是否被释放过,如果不存在该窗体,则 new 一个字窗体  
            if (instance == null || instance.IsDisposed)
            {
                instance = new AnalysisMethodForm();
            }
            return instance;
        }

 
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (model.GetLateNameStatus().Count != 3 || model.GetHistoryrun().Count != 1)
            {
                MessageBox.Show("请选中分析对象和运行次数", "温馨提示", MessageBoxButtons.OK);
                return;
            }
            string strTreeNodeText = e.Node.Text;
            switch (strTreeNodeText)
            {
                case "基本分析":
                    
                    BasicalDataAnalyzeMain basicalDataAnalyzeWnd = new BasicalDataAnalyzeMain();
                    basicalDataAnalyzeWnd.Show(this);
                    
                    break;
                case "简单线性回归":
                     AssociatedAtrributionForm associatedAtrributionForm = new AssociatedAtrributionForm();
                    associatedAtrributionForm.ShowDialog();
                    if (associatedAtrributionForm.DialogResult==(DialogResult.OK))
                    {
                        AsscociationAnalyzeMain asscociationAnalyzeMain = new AsscociationAnalyzeMain();
                       agent.asscociationAnalyzeMain = asscociationAnalyzeMain;
                        asscociationAnalyzeMain.Show(this);
                    //    asscociationAnalyzeMain.MdiParent = this;
                    }
                   
                    break;
                case "关联":    
                    //Appriori
                     DigAssociationAnalyzeMain digAssociationAnalyzeMain = new DigAssociationAnalyzeMain();
                    digAssociationAnalyzeMain.Show(this);
                   // digAssociationAnalyzeMain.MdiParent = this;
                    break;
                case "时域分析":
                    SimulatingStatisticsAnalyzeMain simulatingStatisticsAnalyzeMain=new SimulatingStatisticsAnalyzeMain();
                    simulatingStatisticsAnalyzeMain.Show(this);
                   // simulatingStatisticsAnalyzeMain.MdiParent = this;
                    break;
                case "分类":
                    ClassifyMain classifyMain = new ClassifyMain();
                    classifyMain.Show(this);
                   // classifyMain.MdiParent = this;
                    break;
                default:
                    break;

            }

        }

    }
}
