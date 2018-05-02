using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
namespace Analysis.FormUtils
{
    class ZedUtils
    {

        public static void removeAllCurves(CurveList myCurveList)
        {
            if (myCurveList == null) return;
            for (int i = 0; i < myCurveList.Count; )
            {
                myCurveList.Remove(myCurveList[i]);
            }
        }
       

        public static PointPairList getStepValueFromService( string stepValueURL,string reqStr)
        {
            PointPairList list = new PointPairList();
            DataFromService service = new DataFromService();
            string result = service.HttpGet(stepValueURL + reqStr);
            string[] arrStepValue = result.Split('-');
            for (int i = 0; i + 1 < arrStepValue.Length; i = i + 2)
            {
                list.Add(Double.Parse(arrStepValue[i]), Double.Parse(arrStepValue[i + 1]));
            }
            return list;
        }
        //绘图区域显示的统计数据的曲线----------------------------------------
        public static void showRequeredStaCurves(List<Statsitic> staCurrentList, CurveList myCurveList)
        {

            for (int i = 1; i < myCurveList.Count; i++)
            {
                myCurveList[i].IsVisible = false;

            }
            if (staCurrentList == null)
            {
                return;
            }

            for (int i = 0; i < staCurrentList.Count; i++)
            {
                int index = myCurveList.IndexOf(staCurrentList[i].Type);
                if (index >= 0)
                {
                    myCurveList[index].IsVisible = true;
                }
            }
          
        }

        //*服务*/、加载窗体时调用此方法获取四个统计值并返回，**顺序一定：最大、最小、平均值、方差………………………………………………
        public static List<Statsitic> getStatsticsFromService(string staURL,string reqStr)
        {
            int j = 0;
            List<Statsitic> list = new List<Statsitic>();
            DataFromService service = new DataFromService();
            Statsitic sta;
            String results = service.HttpGet(staURL + reqStr);
            string[] arrSta = results.Split('-');
            while (j + 1 < arrSta.Length)
            {
                sta = new Statsitic(arrSta[j], Math.Round(System.Convert.ToDouble(arrSta[j + 1]), 3));
                list.Add(sta);
                j = j + 2;
            }
            return list;
        }
    }
}
