using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Engines
{
    class icodef : ISearchEngine
    {
        public Structs.EngineInfo EngineInfo { get => new Structs.EngineInfo { Author = "Dev_ken", Provider = "CXmooc-tool developer Team", Name = "iCodeF 题库", Message = "在线题库由CXmooc-tool developer Team维护\n该在线题库目前并不收取任何费用,请不要滥用/恶意攻击,谢谢!", RatelimitPerHour = -1 }; }

        public Structs.SearchResult Search(Structs.SearchInput input)
        {
            var formData = new Dictionary<string, string>
            {
                {"id","0"},
                {"question",input.Keywords},
                {"type",((int)input.Type).ToString()}
            };
        }

        public static string POST(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
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
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
