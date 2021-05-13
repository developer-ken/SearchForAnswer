using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SearchEngine.Engines
{
    public class icodef : ISearchEngine
    {
        public static Structs.EngineInfo engineInfo;
        public Structs.EngineInfo EngineInfo => engineInfo;

        public bool Loaded => engineInfo.Version > new Version(0, 0, 0, 1);

        private const string SearchUrl = "http://cx.icodef.com/wyn-nb?v=2";
        private const string InfoUrl = "http://cx.icodef.com/update?s=wyn2";
        private readonly string Token = "";


        public icodef(string token = "")
        {
            Token = token;
            if (engineInfo.Name == null) engineInfo = new() { Author = "Dev_ken", Provider = "CXmooc-tool developer Team", Name = "iCodeF 题库", Message = "在线题库由CXmooc-tool developer Team维护\n该在线题库目前并不收取任何费用,请不要滥用/恶意攻击,谢谢!", RatelimitPerHour = -1, Version = new Version(0, 0, 0, 1) };

            new Thread(new ThreadStart(() =>
            {
                var result_json = JObject.Parse(GET(InfoUrl));
                engineInfo.Version = new Version(result_json.Value<string>("version"));
                engineInfo.Message = result_json.Value<string>("injection");
            })).Start();
        }

        public Structs.SearchResult Search(Structs.SearchInput input)
        {
            var formData = new Dictionary<string, string>
            {
                {"id","0"},
                {"question",input.Keywords},
                {"type",((int)input.Type).ToString()}
            };
            var strret = POST(SearchUrl, formData);
            var result_json = JObject.Parse(strret);
            return new() { Answer = result_json.Value<string>("data"), ServerMessage = result_json.Value<string>("msg") };
        }

        public string POST(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.Headers.Add("Authorization", Token);
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

        public string GET(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.Headers.Add("Authorization", Token);
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
