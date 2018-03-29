﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Analysis
{
    public partial class BasicalStastisticsForm : Form
    {
        private List<Statsitic> items = null;                                        //统计数据列表
        public InteractiveAgent agent = InteractiveAgent.getInstance();      //中介类
        public SchemeModel model = SchemeModel.getInstance();                //模型类

       // private static BasicalStastisticsForm basicalStastiticWnd = new BasicalStastisticsForm();
        //获取窗体单例----------------
      /*  public static BasicalStastisticsForm getBasicalStaWndInstance()
        {
            if (basicalStastiticWnd == null)
            {
                basicalStastiticWnd = new BasicalStastisticsForm();
            }
            return basicalStastiticWnd;
        }
       * */

        //私有构造函数---------------
        public BasicalStastisticsForm()
        {
            initailWnd();
        }

        public void initailWnd()
        {

            InitializeComponent();
            items = new List<Statsitic>();
            this.items = model.getAllStastitic();
            setListView(items);                   //将统计数据植入窗体
        }

        /// <summary>
        /// 根据封装后的数据Statistics录入窗体统计值表项-----------------------------
        /// </summary>
        /// <param name="items"></param>
        public void setListView(List<Statsitic> items)
        {
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
            model.setStaCurrentList(list);                         //实时设置model的staCurrentList
            agent.informZedFormShowInformedStatistics();            //调用中介类，以期待中介类完成通知DataZedGraphicForm画出线条
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

        }
    }


}
