using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSEvilTestor.testfunc
{
    class CSLEConvert
    {
        public static CSLE.ICLS_Environment env;
        public static object FromJson(string ScriptTypeName, string data)
        {
            var type = env.GetTypeByKeywordQuiet(ScriptTypeName);
            CSLE.SType stype = type.function as CSLE.SType;
            CSLE.SInstance s = new CSLE.SInstance();
            s.type = stype;
            s.member["name"] = new CSLE.CLS_Content.Value();
            s.member["name"].type = typeof(string);
            s.member["name"].value = "testname";

            return s;

        }
        public static string ToJson(object ScriptObject)
        {
            return null;
        }
    }
}
