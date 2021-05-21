using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Engines
{
    public interface ILoginSearchEngine : ISearchEngine
    {
        /// <summary>
        /// 登录到搜题引擎
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="othinfo">附加信息</param>
        /// <returns></returns>
        public bool Login(string user, string password, string othinfo = "");

        public Bitmap Captcha(string othinfo = "");
    }
}
