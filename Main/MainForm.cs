using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Analysis {
    public partial class MainForm : Form {


        public InteractiveAgent agent = InteractiveAgent.getInstance();
        SchemeListForm schemelist;
        DataZedGraphicForm datagraph;
        SchemeRunTimesForm runtime;
        OperationRecordForm record;
        AnalysisMethodForm analysismethod;
        Attribute attribute;
         
        public MainForm() {
            InitializeComponent();
            load();
        }

        private void load() {

            schemelist = SchemeListForm.CreateFrom();
            datagraph = new DataZedGraphicForm();
            runtime = new SchemeRunTimesForm();
            record = new OperationRecordForm();
            attribute = new Attribute();
            analysismethod = AnalysisMethodForm.CreateFrom();
            schemelist.Show(dockPanel1, DockState.DockLeft);
            datagraph.Show(dockPanel1, DockState.Document);

            
            //schemelist.Show(datagraph.Pane, DockAlignment.Left, 0.23);
            analysismethod.Show(datagraph.Pane, DockAlignment.Right, 0.3);
            runtime.Show(schemelist.Pane, DockAlignment.Bottom, 0.4);
            attribute.Show(analysismethod.Pane, DockAlignment.Bottom, 0.4);
            record.Show(datagraph.Pane, DockAlignment.Bottom, 0.3);
            //runtime.Show(dockPanel1, DockState.DockBottom);
            //runtime.Show(dockPanel1, DockState.DockLeft); 
             //analysismethod.Show(dockPanel1, DockState.DockRight);
           


            //attribute.Show(dockPanel1, DockState.DockBottom);
            // attribute.Show(dockPanel1, DockState.DockRight);
            
             
            

            agent.datagraph = datagraph;
            agent.runtimes = runtime;
            agent.attribute = attribute;
            agent.record = record;

        }

        private void 分析窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analysismethod = AnalysisMethodForm.CreateFrom();   
        }

        private void 方案列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schemelist = SchemeListForm.CreateFrom();
            schemelist.Show();
           
        }
    }
}
