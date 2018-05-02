using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ZedGraph;


namespace Analysis
{
    public partial class ZedGraphBase : Form
    {
        protected GraphPane myPane;              //ZedGraph面板
        protected Color color;                    //线条颜色
        protected string xText = "";//图像x轴标识
        protected string yText = "";//图像y轴
        protected string title = "";//图像标题
        protected double XMax = 0, XMin = 0;
     
        protected string startStep, endStep;
  		 protected CurveItem myCurve;
        protected SchemeModel model = SchemeModel.getInstance();
        public ZedGraphBase()
        {
        }


        //作动态图,GetStatsticsFromService();
        //   addAllStaCurves();
        public virtual void createZedPane2()
        {
        }
        public void setZedAction()
        {
            zedGraphControl.ZoomStepFraction = 0;
            this.zedGraphControl.PanModifierKeys = Keys.None;
            myPane.XAxis.Scale.MaxAuto = true;
        }
        /// <summary>
        /// 显示坐标点(x,y)
        /// </summary>
        /// <param name="myCurve"></param>
        public void showYAxisPointsText(LineItem myCurve)
        {
            const double offset = 10;//点位和标注的偏置
            for (int i = 0; i < 36; i++)
            {
                PointPair pt = myCurve.Points[i];
                TextObj text = new TextObj(pt.Y.ToString("f2"), pt.X, pt.Y + offset, CoordType.AxisXYScale, AlignH.Left, AlignV.Center);
                text.ZOrder = ZOrder.A_InFront;
                //隐藏标注的边框和填充
                text.FontSpec.Border.IsVisible = false;
                text.FontSpec.Fill.IsVisible = false;

                //标注字体90度显示
                text.FontSpec.Angle = 90;
                myPane.GraphObjList.Add(text);
            }
        }

        //设置显示网格-----------
        private void isGridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isGridCheckBox.Checked == true)
            {
                myPane.YAxis.MajorGrid.IsVisible = true;
                myPane.XAxis.MajorGrid.IsVisible = true;
                this.zedGraphControl.AxisChange();
                this.zedGraphControl.Refresh();
            }
            else
            {
              //  MessageBox.Show("false");
                myPane.YAxis.MajorGrid.IsVisible = false;
                myPane.XAxis.MajorGrid.IsVisible = false;
                this.zedGraphControl.AxisChange();
                this.zedGraphControl.Refresh();
            }
        }

        //鼠标样式----------
        private void GraphAtrributesPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        //设置线的颜色--------
        public void SetLineColor(Color c)
        {
            CurveList curves = myPane.CurveList;
            if (curves.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < curves.Count; i++)
            {
                LineItem curve = curves[i] as LineItem;
                curve.Color = c;
            }
            this.zedGraphControl.AxisChange();
            Refresh();

        }

        //改变线的颜色对话框----------
        public Color lineColorChangeDlg()
        {
            System.Windows.Forms.ColorDialog cdlg = new System.Windows.Forms.ColorDialog();
            cdlg.CustomColors = new int[]
            {
                0x0000ff,0xff0000,0x00ff00,0xffff00,0xfffff
            };

            cdlg.AllowFullOpen = false;
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                this.color = cdlg.Color;
            }
            return this.color;
        }

        //颜色Combobox的响应事件------------
        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color tempColor;
            switch (this.colorComboBox.SelectedIndex)
            {
                case 0:
                    tempColor = Color.Black;
                    break;
                case 1:
                    tempColor = Color.Green;
                    break;
                case 2:
                    tempColor = Color.Blue;
                    break;
                case 3:
                    tempColor = Color.Red;
                    break;
                case 4:
                    tempColor = Color.Pink;
                    break;
                case 5:
                    tempColor = lineColorChangeDlg();
                    break;
                default:
                    tempColor = this.color;
                    break;
            }
            this.color = tempColor;
            SetLineColor(this.color);

        }
      /*  private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dynamicCheckBox.Checked == true)
            {
                this.dynamicTimer.Enabled = true;
            }
            else
            {
                this.dynamicTimer.Enabled = false;
            }
        }
       * */
        protected virtual void dynamicTimer_Tick(object sender, EventArgs e)
        {

        }
        //载入数据响应
        protected virtual void loadDataButton_Click(object sender, EventArgs e)
        {
        }
        //随机颜色
        public Color GetRandomColor()
        {
            Random RandomNum_First = new Random((int)DateTime.Now.Ticks);
            //  对于C#的随机数，没什么好说的
            System.Threading.Thread.Sleep(RandomNum_First.Next(50));
            Random RandomNum_Sencond = new Random((int)DateTime.Now.Ticks);

            //  为了在白色背景上显示，尽量生成深色
            int int_Red = RandomNum_First.Next(256);
            int int_Green = RandomNum_Sencond.Next(256);
            int int_Blue = (int_Red + int_Green > 400) ? 0 : 400 - int_Red - int_Green;
            int_Blue = (int_Blue > 255) ? 255 : int_Blue;

            return Color.FromArgb(int_Red, int_Green, int_Blue);
        }
        //删除
       

        protected virtual void defaultButton_Click(object sender, EventArgs e) { }

        protected virtual void redrawButton_Click(object sender, EventArgs e) { }
    }
}

