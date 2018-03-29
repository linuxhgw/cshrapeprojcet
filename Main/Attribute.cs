using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis {
    public partial class Attribute : WeifenLuo.WinFormsUI.Docking.DockContent {
        public InteractiveAgent agent = InteractiveAgent.getInstance();
        public SchemeModel model = SchemeModel.getInstance();
        public List<string> message = new List<string>();
        public Attribute() {
            InitializeComponent();
        }


        public void Message() {
            message =  model.GetLateNameStatus();
            message.Add("");
            message.Add("");
            message.Add("");
            textBox1.Text = message[0];
            textBox2.Text = message[1];
            textBox3.Text = message[2];
        }
    }
}
