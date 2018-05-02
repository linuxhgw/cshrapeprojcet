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
    public partial class SimulatingStatisticsForm : Form
    {
        private List<Statsitic> items;                                        //统计数据列表
        public InteractiveAgent agent = InteractiveAgent.getInstance();      //中介类
        public SchemeModel model = SchemeModel.getInstance();

        //构造函数---------------
        public SimulatingStatisticsForm()
        {
             InitializeComponent();
            initWnd();                                                //将统计数据植入窗体
        }

        //初始化
        public void initWnd(){
          
            items = new List<Statsitic>();
            setDefaultStastistics(items);
            setListView(items);
        }

        //默认显示
        public void setDefaultStastistics(List<Statsitic> item)
        {
            Statsitic s1 = new Statsitic("超调量");
            Statsitic s2 = new Statsitic("调节时间");
            Statsitic s3 = new Statsitic("振荡次数");
            Statsitic s4 = new Statsitic("延迟时间");
            Statsitic s5 = new Statsitic("上升时间");
            Statsitic s6 = new Statsitic("峰值时间");
            item.Add(s1);
            item.Add(s2);
            item.Add(s3);
            item.Add(s4);
            item.Add(s5);
            item.Add(s6);
        }

        //统计数据织入窗体
        public void setListView(List<Statsitic> items)
        {
            staWndListview.Items.Clear();
            ListViewItem listItem;
            for (int j = 0; j < items.Count; j++)
            {
                listItem = new ListViewItem();
                listItem.SubItems[0].Text = items[j].Type;
                listItem.SubItems.Add(items[j].Val.ToString());
                staWndListview.Items.Add(listItem);
            }
        }

        //窗口放大时listview的样式：列平均--------------------------------
        private void listView1_Resize(object sender, EventArgs e)
        {
            int _Count = this.staWndListview.Columns.Count;
            int _Width = staWndListview.Width;
            foreach (ColumnHeader ch in staWndListview.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }

        //check选择后，将触动SchemeModel，改变staCurrentList   //统计数值-----------------------------
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //MessageBox.Show("调用");
            List<Statsitic> list = new List<Statsitic>();
            for (int i = 0; i < staWndListview.Items.Count; i++)
            {
                if (staWndListview.Items[i].Checked)
                {
                    string type = staWndListview.Items[i].SubItems[0].Text;
                    double value = Double.Parse(staWndListview.Items[i].SubItems[1].Text);
                    list.Add(new Statsitic(type, value));
                }
            }
            model.setSimuCurrentList(list);                         //实时设置model的staCurrentList
            agent.informSimuZedFormShowInformedStatistics();            //调用中介类，以期待中介类完成通知DataZedGraphicForm画出线条
        }

        //还原默认显示时，设置CheckBox为false------------------------
        public void setAllCheckboxNon()
        {
            for (int i = 0; i < staWndListview.Items.Count; i++)
            {
                if (staWndListview.Items[i].Checked == true)
                {
                    staWndListview.Items[i].Checked = false;
                }
            }
            model.setSimuCurrentList(null);
            agent.informSimuZedFormShowInformedStatistics();
        }

        //中介者通知取数据--------------------------------------
        public void informedToGetAllSimuStastistic()
        {
            items = model.getAllSimuStatistic();
            setListView(items);
        }

    }
}
