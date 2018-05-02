using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analysis
{
    class ReqStr

    {
        //单例模式
        public static ReqStr instance = new ReqStr();

        private ReqStr()
        {

        }
        public static ReqStr getInstance()
        {
            if (instance == null)
            {
                instance = new ReqStr();
            }
            return instance;
        }
        private string aprioriURL;
        private string staURL;
        private string stepValueURL;
        private string LinearBackURL;
        //attrId=datacollect0-3-1-3&steplength=1-5000";
        private string LoadFormula;
        private string loadFormulaList1;
        private string simuURL;
        private string simpLinearURL;


        public void UrlTest() {
          aprioriURL = "http://172.16.73.125:9999/getAprioriResult?tb=";
            staURL = "http://172.16.73.125:9999/getBasicStatisticsAnalysis?reqStr=datacollect";
            stepValueURL = "http://172.16.73.125:9999/getAtrributeRunData?reqStr=datacollect";
            LinearBackURL = "http://172.16.73.125:9999/getLinearRegressionResult?";
            LoadFormula = "http://172.16.73.125:9999/LoadFormula";
            simuURL = "http://172.16.73.125:9999/getTimeDomainAnalysis?reqStr=datacollect";
            loadFormulaList1 = "http://172.16.73.125:9999/LoadFormulaList1";
            simpLinearURL = "http://172.16.73.125:9999/getSimpleLRResult?";
        }
        public void Url()
        {
            aprioriURL = "http://localhost:9999/getAprioriResult?tb=";
            staURL = "http://localhost:9999/getBasicStatisticsAnalysis?reqStr=datacollect";
            LoadFormula = "http://localhost:9999/LoadFormula";
            LinearBackURL = "http://localhost:9999/getLinearRegressionResult?";
            stepValueURL = "http://localhost:9999/getAtrributeRunData?reqStr=datacollect";
            simuURL= "http://localhost:9999/getTimeDomainAnalysis?reqStr=datacollect";
            loadFormulaList1 = "http://localhost:9999/LoadFormulaList1";
            simpLinearURL = "http://localhost:9999/getSimpleLRResult?";
        }
        public string AprioriURL { get => aprioriURL; set => aprioriURL = value; }
        public string StaURL { get => staURL; set => staURL = value; }
        public string StepValueURL { get => stepValueURL; set => stepValueURL = value; }
        public string LinearBackURL1 { get => LinearBackURL; set => LinearBackURL = value; }
        public string LoadFormula1 { get => LoadFormula; set => LoadFormula = value; }
        public string SimuURL { get => simuURL; set => simuURL = value; }
        public string LoadFormulaList1 { get => loadFormulaList1; set => loadFormulaList1 = value; }
        public string SimpLinearURL { get => simpLinearURL; set => simpLinearURL = value; }
    }
}
