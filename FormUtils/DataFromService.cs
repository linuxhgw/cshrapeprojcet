using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Analysis
{

    
    public class DataFromService
    {
        //http获取服务端数据
        public string HttpGet(string url)
        {
            Console.WriteLine("传过来的地址是" + url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            try
            {

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                Console.WriteLine(retString);
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;


            }
            catch (Exception)
            {
                MessageBox.Show("没有连上服务器", "温馨提示", MessageBoxButtons.OK);
                return "" ;
            }
          
         
            
        }

        public DataFromService()
        {

        }
    }
}
