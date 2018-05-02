using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis {

    public class SchemeModel {

        private static SchemeModel instance = new SchemeModel();


        //让构造函数为 private，这样该类就不会被实例化 
        private SchemeModel() {
        }

        //获取唯一可用的对象
        public static SchemeModel getInstance() {
            if (instance == null) {
                instance = new SchemeModel();
            }
            return instance;
        }

        List<string> status = new List<string>();

        List<int> runtime = new List<int>();

        string late="";
        private string startStep = "30", endStep = "50";              //仿真步长区间
        private double[] linearResults = new double[3];         //线性相关参数
        private List<Statsitic> simuCurrentList = new List<Statsitic>();
        private List<Statsitic> staCurrentList = new List<Statsitic>();     //统计数值
        private string anotherAttribute = "";        //小弹窗：关联窗口的同一个成员的两个属性记录
        private string anotherAttributeId;
        private bool isDynamicLoad = false;
        private List<Statsitic> allStastistic=null,allSimuStatistic=null;

        public void AddStatus(string str) {
            
            int flag = 0;
            late = str;
            for (int i = 0; i < status.Count; i++) {
                if (status[i].Equals(str)) {
                    flag = 1;

                    break;
                }
            }
            if (flag == 0) {
               
                status.Add(str);

            }

        }

        public List<string> GetLateNameStatus() {
            List<string> path = new List<string>();
            int stringfont = 0;//记录一个节点的起始信息
           // Console.WriteLine(late.Length);
            if (late.Length > 6) {
                if (late.Substring(0, 6).Equals("全部方案信息"))
                    late = late.Substring(6, late.Length - 6);
            }
            Console.WriteLine(late.Length);
            for (int i = 0; i < late.Length - 1; i++) {
                if (late.Substring(i, 1).Equals("\\")) {

                    if (stringfont == i) {
                        stringfont = i + 1;
                        continue;
                    }
                       
                    path.Add(late.Substring(stringfont, i - stringfont));
                    stringfont = i + 1;
                }
            }
            for (int i = late.Length - 1; i >= 0; i--)
            {
                if (late.Substring(i, 1).Equals("\\"))
                {
                    path.Add(late.Substring(stringfont, late.Length - stringfont));
                    break;
                }
            }
            return path;
        }

        public List<int> GetLateIdStatus()
        {
            List<string> name;
            List<int> id = new List<int>();

            List<string[]> split_list = new List<string[]>();
            name = GetLateNameStatus();

            if (name.Count == 0)
                return null;
            for (int i = 0; i < name.Count; i++)
            {

                split_list.Add(name[i].Split('-'));

            }
            for (int i = 0; i < split_list.Count; i++)
            {
                id.Add(Int32.Parse(split_list[i][1]));
            }


            for (int i = 0; i < id.Count; i++)
            {
                Console.WriteLine("id为" + id[i]);
            }

            return id;
        }


        public void AddHistoryrun(List<string> runtimes) {
            runtime.Clear() ;
            for (int i = 0; i < runtimes.Count; i++) {
                runtime.Add(Int32.Parse(runtimes[i]));
            }

        }

        public List<int> GetHistoryrun() {
            return runtime; 
        }

        //获取成员下所有属性…………………………………………………………………………………………………………………………
        public List<string> getMemberAttrbutes()
        {
            return null;
        }
        //设置基本统计数据
        public void setAllStatistic(List<Statsitic> list)
        {
            this.allStastistic = list;
        }
        //获取基本统计数据
        public List<Statsitic> getAllStastitic()
        {
            return this.allStastistic;
        }
     
        public void setIsDynamicLoad(bool dynamic)
        {
            this.isDynamicLoad = dynamic;
        }

        public bool getDynamicLoad()
        {
            return this.isDynamicLoad;
        }
        //获取起始步长
        public string getStartStep()
        {
            return this.startStep;
        }
        //设置起始步长
        public void setStartStep(string step)
        {
            this.startStep = step;
        }
        //获取目的步长
        public string getEndStep()
        {
            return endStep;
        }
        //设置目的步长
        public void setEndStep(string step)
        {
            this.endStep = step;
        }
        //统计数据列表勾选后，设置staCurrentList的值---------------------------
        public void setStaCurrentList(List<Statsitic> staList)
        {
            this.staCurrentList = staList;
        }

        //取出要显示的统计数值------------------------------
        public List<Statsitic> getStaCurrentList()
        {
            return this.staCurrentList;
        }
        //设置关联属性小弹窗关联属性--------------------------
        public void setAssociatedAttibuteName(string attribute)
        {
            this.anotherAttribute = attribute;
        }

        //获取关联属性小弹窗关联属性-----------------------------
        public string getAssociatedAttibuteName()
        {
            return this.anotherAttribute;
        }

        //设置关联属性id
        public void setAssociatedAttibuteId(string id)
        {
            this.anotherAttributeId = id;
        }
        //设置关联属性id
        public string getAssociatedAttibuteId()
        {
            return this.anotherAttributeId;
        }
     //设置所有仿真时域统计数据
        public void setAllSimuStatistic(List<Statsitic> list)
        {
            this.allSimuStatistic = list;
        }
        //获取所有仿真时域统计数据
        public List<Statsitic> getAllSimuStatistic()
        {
            return this.allSimuStatistic;
        }
        public List<Statsitic> getSimuCurrentList()
        {
           return this.simuCurrentList;
        }

        public void setSimuCurrentList(List<Statsitic> list)
        {
            this.simuCurrentList = list;
        }

        //设置简单线性回归参数
        public void setlinearResults(double[] list)
        {
            if (list.Length != 3)
            {
                return;
            }
            this.linearResults = list;
        }

        //获取简单线性回归参数
        public double[] getlinearResults()
        {
            return linearResults;
        }
        //*测试*输出staList***************
        public void printStaList(List<Statsitic> list)
        {
            foreach (Statsitic temp in list)
            {
                MessageBox.Show("列表长度：" + list.Count + "  " + temp.Type + "  " + temp.Val);
            }
        }


   

    }
}
   

