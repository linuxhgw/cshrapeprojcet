using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analysis {
    public class InteractiveAgent {
        public DataZedGraphicForm datagraph;
        public SchemeListForm schemelist;
        public SchemeRunTimesForm runtimes;
        public OperationRecordForm record;
        public Attribute attribute;
        public BasicalStastisticsZedForm basicalStastisticsZedForm;
        public BasicalStastisticsForm basicalStastiticWnd;
        public SimulatingStatisticsZedForm simulatingStatisticsZedForm;
        public SimulatingStatisticsForm simulatingStatisticsForm;
        public AssociatedZedForm associatedZedForm;

        //创建 SingleObject 的一个对象
        private static InteractiveAgent instance = new InteractiveAgent();


        //让构造函数为 private，这样该类就不会被实例化 
        private InteractiveAgent() {
        }
        
        //获取唯一可用的对象
        public static InteractiveAgent getInstance() {
            if (instance == null) {
                instance = new InteractiveAgent();
            }
            return instance;
        }
        public void SchemeToDataGraphic() {
            instance.datagraph.SchemeMessage();
        }

        public void SchemeToRuntimes()
        {
            instance.runtimes.runtimeMessage();
        }

        public void RuntimeToDataGraghic()
        {
            instance.datagraph.runtimesage();
        }

        public void SchemeToAtrr()
        {
            instance.attribute.Message();
        }

        public void SchemeToRecord()
        {
            instance.record.Message();
        }

        public void RuntimeToRcord()
        {
            instance.record.RunMessage();
        }

        //通知BasicalStastisticsZedForm设置当前统计参数
        public void informZedFormShowInformedStatistics()
        {
            basicalStastisticsZedForm.informedToGetCurStaList();
        }

        //通知SimulatingStatisticsZedForm设置当前统计参数
        public void informSimuZedFormShowInformedStatistics()
        {
            simulatingStatisticsZedForm.informedToGetCurSimuList();
        }
       
        //通知SimuStastisticFrom获取所有的仿真统计数据
        public void informSimuStastisticFromRefreshNewData()
        {
            simulatingStatisticsForm.informedToGetAllSimuStastistic();
        }
        public void informBasicalStastisticFromRefreshNewData()
        {
            basicalStastiticWnd.informedToGetAllStastistic();
        }

        //通知BasicalStastisticsForm将checkbox全部不选
        public void informStaWndAllNonCheck()
        {
            basicalStastiticWnd.setAllCheckboxNon();
        }

        //通知SimulatingStatisticsForm将checkbox全部不选
        public void informSimuWndAllNonCheck()
        {
            simulatingStatisticsForm.setAllCheckboxNon();
        }

        public void informZedGetCoff()
        {
            associatedZedForm.getcoefficient();
        }


    }
}
