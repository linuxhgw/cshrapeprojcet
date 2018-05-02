using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis.PartsForm
{
    public partial class LoadDataForm : Form
    {

        SchemeModel model = SchemeModel.getInstance();
        public LoadDataForm()
        {
            InitializeComponent();
        }

       
        private void staticLoadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            model.setIsDynamicLoad(false);
        }

        private void dynamicaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            model.setIsDynamicLoad(true);
        }

      
    }
}
