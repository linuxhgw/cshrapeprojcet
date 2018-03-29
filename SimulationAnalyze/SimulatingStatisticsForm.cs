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
        public SchemeModel model = SchemeModel.getInstance();                //模型类
        //构造函数---------------
        public  SimulatingStatisticsForm()
        {
            InitializeComponent();
            items = new List<Statsitic>();
            InitializeStastisticList(getSimuStastisticsFromService(null));          //获取并封装统计数据
            setListView(items);                                         //将统计数据植入窗体
        }



        //加载窗体时调用此方法获取四个统计值并返回，**顺序一定：超调量", "调节时间", "振荡次数", "延迟时间","上升时间","峰值时间………………………………………………
        public double[] getSimuStastisticsFromService(string reqStr)
        {
            double[] arr = { 20, 5, 10, 44, 33, 22 };
            return arr;
        }

        /// <summary>
        /// 根据服务获取数据，封装各统计项，并初始化，默认为0.0
        /// </summary>
        public void InitializeStastisticList(double[] dataArray)
        {

            Statsitic maxDeviation;
            Statsitic responseTime;
            Statsitic frequency;
            Statsitic delayTime;
            Statsitic upTime;
            Statsitic peakTime;
            maxDeviation = new Statsitic("超调量");       //默认值为0
            items.Add(maxDeviation);
            responseTime = new Statsitic("调节时间");
            items.Add(responseTime);
            frequency = new Statsitic("振荡次数");
            items.Add(frequency);
            delayTime = new Statsitic("延迟时间");
            items.Add(delayTime);
            upTime = new Statsitic("上升时间");
            items.Add(upTime);
            peakTime = new Statsitic("峰值时间");
            items.Add(peakTime);


            if (dataArray != null)
            {
                for (int i = 0; i < dataArray.Length; i++)
                {
                    items[i].Val = dataArray[i];
                }
            }
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

        }
    }
}
