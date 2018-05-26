using Analysis.Main;
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
            Selectmessage customer = new Selectmessage();
            customer.Scheme = message[0];
            customer.Member = message[1];
            customer.Attribute = message[2];
            
            propertyGrid1.SelectedObject = customer;
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
