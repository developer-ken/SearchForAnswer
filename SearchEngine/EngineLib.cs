﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    public class EngineLib
    {
        public static Action<string> Msgbox;
        public static Engines.ISearchEngine Get(string engineName, string token = "")
        {
            switch (engineName)
            {
                case "icodef":
                    return new Engines.icodef(token);
                case "本地题库":
                    return new Engines.LocalSearch();
            }
            throw new Exception("Engine name not exists.");
        }

        public static List<string> List()
        {
            return new() { "icodef", "本地题库" };
        }
    }
}
