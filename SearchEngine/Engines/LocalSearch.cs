using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchEngine.Engines
{
    class LocalSearch : ISearchEngine
    {
        public const long NON_MEMCACHE_SIZE_THREHOLD = 1024 * 1024 * 1024;//1M

        public Structs.EngineInfo EngineInfo => new Structs.EngineInfo
        {
            Author = "Developer_ken",
            NeedCaptcha = false,
            NeedLogin = false,
            Message = "从本地题库中查找题目。请将本地数据库文件(.ldb)放置在打开的文件夹中。",
            Provider = "Local",
            Name = "本地查题",
            RatelimitPerHour = -1,
            Version = new Version(0, 1)
        };

        public bool Loaded { private set; get; }
        private bool memcached = false;
        private string[] files;

        Dictionary<string, string> datastore;

        public LocalSearch()
        {
            Directory.CreateDirectory("./localdb");
            files = Directory.GetFiles("./localdb", "*.ldb", SearchOption.AllDirectories);
            while (files.Length < 1)
            {
                Process.Start("explorer", Path.GetFullPath("./localdb"));
                EngineLib.Msgbox.Invoke("没有可用的数据库，请将本地数据库(.ldb)存入打开的文件夹。");
                files = Directory.GetFiles("./localdb", "*.ldb", SearchOption.AllDirectories);
            }

            long totalsize = 0;
            foreach (var f in files)
            {
                var finfo = new FileInfo(f);
                totalsize += finfo.Length;
            }

            memcached = (totalsize <= NON_MEMCACHE_SIZE_THREHOLD);
            if (memcached)
            {
                datastore = new Dictionary<string, string>();
                foreach (var f in files)
                {
                    var lines = File.ReadAllLines(f);
                    foreach (var l in lines)
                    {
                        JObject jb = JObject.Parse(l);
                        try
                        {
                            datastore.Add(jb.Value<string>("q"), jb.Value<string>("a"));
                        }
                        catch (ArgumentException err)
                        {
                            EngineLib.Msgbox("题库文件\"" + Path.GetFileName(f) + "\"存在一处错误：\n" + err.Message);
                        }
                    }
                }
            }
        }

        public Structs.SearchResult Search(Structs.SearchInput input)
        {
            if (memcached)
            {
                foreach (var kvp in datastore)
                {
                    if (Regex.IsMatch(kvp.Key, ".*" + input.Keywords + ".*"))
                    {
                        return new Structs.SearchResult { Answer = kvp.Value, ServerMessage = "本地查询成功" };
                    }
                }
            }
            else
            {
                while (files.Length < 1)
                {
                    Process.Start("explorer", Path.GetFullPath("./localdb"));
                    EngineLib.Msgbox.Invoke("没有可用的数据库，请将本地数据库(.ldb)存入打开的文件夹。");
                    files = Directory.GetFiles("./localdb", "*.ldb", SearchOption.AllDirectories);
                }
                foreach (var f in files)
                {
                    StreamReader sr = new StreamReader(f);
                    do
                    {
                        JObject jb = JObject.Parse(sr.ReadLine());
                        if (Regex.IsMatch(jb.Value<string>("q"), ".*" + input.Keywords + ".*"))
                        {
                            return new Structs.SearchResult { Answer = jb.Value<string>("a"), ServerMessage = "本地查询成功" };
                        }
                    } while (!sr.EndOfStream);
                }
            }
            return new Structs.SearchResult { Answer = "", ServerMessage = "题库中没有相关信息" };
        }
    }
}
