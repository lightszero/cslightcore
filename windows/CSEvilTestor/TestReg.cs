using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSEvilTestor
{
    class TestReg
    {
        delegate void ma(int a,string b);

        public static void Reg(CSLE.ICLS_Environment env)
        {
            CSEvilTestor.testfunc.CSLEConvert.env = env;

            env.RegType(new CSLE.RegHelper_Type(typeof(Debug)));
            env.RegType(new CSLE.RegHelper_Type(typeof(testfunc.CSLEConvert)));

            env.RegType(new CSLE.RegHelper_Type(typeof(TestDele)));
            env.RegType(new CSLE.RegHelper_Type(typeof(Program)));

            env.RegType(new CSLE.RegHelper_Type(typeof(MyJson), "MyJson"));
            env.RegType(new CSLE.RegHelper_Type(typeof(MyJson.JsonNode_ValueNumber), "MyJson.JsonNode_ValueNumber"));
            env.RegType(new CSLE.RegHelper_Type(typeof(MyJson.IJsonNode), "MyJson.IJsonNode"));
            env.RegType(new CSLE.RegHelper_Type(typeof(MyJson.JsonNode_ValueString), "MyJson.JsonNode_ValueString"));
            env.RegType(new CSLE.RegHelper_Type(typeof(MyJson.JsonNode_Object), "MyJson.JsonNode_Object"));
            env.RegType(new CSLE.RegHelper_Type(typeof(MyJson.JsonNode_Array), "MyJson.JsonNode_Array"));


            //env.RegType(new CSLE.RegHelper_DeleAction<int,string>(typeof(Action<int,string>),"Action<int,string>"));
            env.RegType(new CSLE.RegHelper_Type(typeof(MyClass2)));
            env.RegType(new CSLE.RegHelper_DeleAction<MyClass2>(typeof(Action<MyClass2>), "Action<MyClass2>"));

            //env.RegType(new CSLE.RegHelper_DeleAction<int>(typeof(Action<int>), "Action<int>"));
            //env.RegType(new CSLE.RegHelper_DeleAction(typeof(Action),"Action"));
            env.RegType(new CSLE.RegHelper_DeleAction(typeof(TestDele.myup), "TestDele.myup"));

            Action<int> reg1 =(i)=>{};
            CSLE.RegHelper_Dele_Util.RegWithDelegate(env, reg1,"Action<int>");
            CSLE.RegHelper_Dele_Util.RegWithDelegate(env, (Action)(()=>{}), "Action");

            Action<int, string> reg2 = (i, j) => { };
            CSLE.RegHelper_Dele_Util.RegWithDelegate(env, reg2, "Action<int,string>");


            env.RegType(new CSLE.RegHelper_Type(typeof(Color), "Color"));

            env.RegType(new CSLE.RegHelper_Type(typeof(KeyValuePair<,>), "KeyValuePair"));
            env.RegType(new CSLE.RegHelper_Type(typeof(HashSet<object>), "HashSet<object>"));

            //env.RegType(new CSLE.RegHelper_Type(typeof(List<string>), "List<string>"));
            env.RegType(new CSLE.RegHelper_Type(typeof(int[]), "int[]"));

            //env.RegType(new CSLE.RegHelper_Type(typeof(List<int>), "List < int>"));
            //env.RegType(new CSLE.RegHelper_Type(typeof(List<List<int>>), "List<List<int>>"));
            //env.RegType(new CSLE.RegHelper_Type(typeof(List<List<List<double>>>), "List<List<List<double>>>"));
            //env.RegType(new CSLE.RegHelper_Type(typeof(List<List<List<int>>>), "List<List<List<int>>>"));

            env.RegType(new CSLE.RegHelper_Type(typeof(config)));
            env.RegType(new CSLE.RegHelper_Type(typeof(Math)));

            env.RegType(new CSLE.RegHelper_Type(typeof(Exception)));
            env.RegType(new CSLE.RegHelper_Type(typeof(NotSupportedException)));
            env.RegType(new CSLE.RegHelper_Type(typeof(NotImplementedException)));
            env.RegType(new CSLE.RegHelper_Type(typeof(TestClass)));
            env.RegType(new CSLE.RegHelper_Type(typeof(StateMgr)));

        }
        
    }
    public class StateMgr
    {

    }
    public class MyClass2
    {

    }
    class config
    {
        public static int Cell(double i)
        {
            return (int)i;
        }
    }
}
