using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis
{
    public partial class CaseInfoForm : Form
    {
        public SchemeModel model = SchemeModel.getInstance();
        public CaseInfoForm()
        {
            InitializeComponent();
            setCaseInfoListView(InitializeCaseInfo());
        }
        //方案名,成员,属性
        public List<string> InitializeCaseInfo()
        {
            List<string> list = model.GetLateNameStatus();
            List<string> listPre = new List<string>();
            listPre.Add((list.Count - 1).ToString());//
            listPre.Add("方案名称");
            listPre.Add(list[0]);

            //  listPre.Add("属性");
            for (int i = 1; i + 1 < list.Count; i = i + 2)
            {
                listPre.Add("成员-属性");
                listPre.Add(list[i] + "-" + list[i + 1]);
            }
            string anotherAttribute = model.getAssociatedAttibuteName();

            string anotherAttributeId = model.getAssociatedAttibuteId();
            if (!anotherAttribute.Equals(""))
            {
                listPre.Add("成员-属性");
                listPre.Add(list[1] + "-" + anotherAttribute+"-"+anotherAttributeId);
                listPre[0] = (Int32.Parse(listPre[0]) + 1).ToString();
            }
            return listPre;
        }

        //设置ListView
        public void setCaseInfoListView(List<string> list)
        {
            ListViewItem lvi;
            int i = 1;
            for (int num = 0; num < Int32.Parse(list[0]); num++, i++)
            {

                lvi = new ListViewItem();
                lvi.SubItems[0].Text = list[i];
                i++;
                lvi.SubItems.Add(list[i]);
                caseInfoListView.Items.Add(lvi);
            }
        }

        //窗口改变时，column的宽度不一样
        private void listView1_Resize(object sender, EventArgs e)
        {
            int _Count = this.caseInfoListView.Columns.Count;
            int _Width = this.caseInfoListView.Width;
            foreach (ColumnHeader ch in this.caseInfoListView.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }
    }
}
