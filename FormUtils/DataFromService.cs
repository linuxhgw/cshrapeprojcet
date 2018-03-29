using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Analysis
{
    public class DataFromService
    {
        //http获取服务端数据
        public string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            Console.WriteLine(retString);
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        public DataFromService()
        {

        }
    }
}
