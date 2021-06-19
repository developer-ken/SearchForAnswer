using Jint;
using Jint.Native;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter
{
    class ScriptEngine
    {
        Engine engine;
        JsValue callhandle_Convert;
        public ScriptEngine(string script)
        {
            engine = new Engine(cfg => cfg.AllowClr());
            engine.Execute(script);
            callhandle_Convert = engine.GetValue("Convert");
        }

        public string[] Convert(string[] row)
        {
            var result = callhandle_Convert.Invoke(JsValue.FromObject(engine, row));

            return new string[] { result.AsArray().Get("0").ToString(), result.AsArray().Get("1").ToString() };
        }
    }
}
