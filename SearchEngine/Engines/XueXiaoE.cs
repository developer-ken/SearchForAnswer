using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Engines
{
    class XueXiaoE : ILoginSearchEngine
    {
        public Structs.EngineInfo EngineInfo => throw new NotImplementedException();
        private string token;

        public bool Loaded => throw new NotImplementedException();

        public Bitmap Captcha(string othinfo = "")
        {
            throw new NotImplementedException();
        }

        public bool Login(string user, string password, string othinfo = "")
        {
            const string URL = "https://app.51xuexiaoyi.com/api/v1/login";
            return false;
        }

        public Structs.SearchResult Search(Structs.SearchInput input)
        {
            throw new NotImplementedException();
        }

        public string POSTForm(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            {
                req.UserAgent = "okhttp/3.11.0";
                req.Headers.Add("accept-encoding", "gzip, deflate, br");
                req.Headers.Add("token", token);
                req.Headers.Add("device", "");
                req.Headers.Add("app-version", "1.0.6");
                req.Headers.Add("platform", "android");
                req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            }
            //req.Headers.Add("Authorization", Token);
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, WebUtility.UrlEncode(item.Value));
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        public string POSTJson(string url, JObject json)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            {
                req.UserAgent = "okhttp/3.11.0";
                req.Headers.Add("accept-encoding", "gzip, deflate, br");
                req.Headers.Add("token", token);
                req.Headers.Add("device", "");
                req.Headers.Add("app-version", "1.0.6");
                req.Headers.Add("platform", "android");
                req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            }
            byte[] data = Encoding.UTF8.GetBytes(json.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
