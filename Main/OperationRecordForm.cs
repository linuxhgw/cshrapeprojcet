using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis {
    public partial class OperationRecordForm : WeifenLuo.WinFormsUI.Docking.DockContent {
         public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();
        public List<string> message = new List<string>();
        public List<int> runtime = new List<int>();

        public OperationRecordForm() {
            InitializeComponent();
        }

        public void Message() {
            message = model.GetLateNameStatus();
            string str ="you cloose:";
            for (int i = 0; i < message.Count; i++) {
                str += message[i];
                str += ":";    
            }
            str += "\n";
            textBox1.AppendText(str);
            
        }

        public void RunMessage() {
            runtime = model.GetHistoryrun();
            string str = "you cloose:";
            for (int i = 0; i < runtime.Count; i++) {
               
                str +="历史记录的第"+ runtime[i]+"次:";
               
            }
            str += "\n";
            textBox1.AppendText(str);
        }
    }
}
