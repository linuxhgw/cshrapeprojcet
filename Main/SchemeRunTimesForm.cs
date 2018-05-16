using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis {
    public partial class SchemeRunTimesForm : WeifenLuo.WinFormsUI.Docking.DockContent {
        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();
        public List<string> message = new List<string>();


        public SchemeRunTimesForm() {
            InitializeComponent();
        } 
        
        public void runtimeMessage() {
            schemeONEruntime();
        }
 
        private void button1_Click(object sender, EventArgs e) {
            //清除checkedListBox1中所有的选项
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                checkedListBox1.Items.Clear();

            }
            schemeONEruntime();
        }

       
        //远端调用方案
        public void schemeONEruntime() {
            //可以知道方案名和方案的成员
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                checkedListBox1.Items.Clear();

            }
            checkedListBox1.Items.Add("1");
            checkedListBox1.Items.Add("2");
            checkedListBox1.Items.Add("3");
            
        }

        private void SchemeRunTimesForm_Load(object sender, EventArgs e) {
            checkedListBox1.CheckOnClick = true; 
        }

        private  void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            message.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                if (checkedListBox1.GetItemChecked(i)) {
                    message.Add(checkedListBox1.GetItemText(checkedListBox1.Items[i]));
                }
            }
            model.AddHistoryrun(message);
            agent.datagraph.runtimesage();
            agent.record.RunMessage();

        }

    }
}
