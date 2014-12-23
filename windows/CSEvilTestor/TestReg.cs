using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSEvilTestor
{
    class TestReg
    {
        delegate void ma(int a, string b);

        public static void Reg(CSLE.ICLS_Environment env)
        {
            CSEvilTestor.testfunc.CSLEConvert.env = env;
            ////传统的注册方法,只适用于class,不支持注册委托
            //env.RegType(new CSLE.RegHelper_Type(typeof(Debug)));
            //env.RegType(new CSLE.RegHelper_Type(typeof(testfunc.CSLEConvert)));

            //env.RegType(new CSLE.RegHelper_Type(typeof(TestDele)));
            //env.RegType(new CSLE.RegHelper_Type(typeof(Program)));

            //新的注册方法,只适用于class,不支持注册委托
            env.RegType(CSLE.RegHelper_Type.Make(typeof(Debug), null));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(testfunc.CSLEConvert), null));

            env.RegType(CSLE.RegHelper_Type.Make(typeof(TestDele), null));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(Program), null));
            //新的注册方法,参数一样的，
            env.RegType(CSLE.RegHelper_Type.Make(typeof(MyJson), "MyJson"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(MyJson.JsonNode_ValueNumber), "MyJson.JsonNode_ValueNumber"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(MyJson.IJsonNode), "MyJson.IJsonNode"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(MyJson.JsonNode_ValueString), "MyJson.JsonNode_ValueString"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(MyJson.JsonNode_Object), "MyJson.JsonNode_Object"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(MyJson.JsonNode_Array), "MyJson.JsonNode_Array"));


            //显式区分注册class 和delegate，其实是一码事
            env.RegType(CSLE.RegHelper_Type.MakeClass(typeof(MyClass2), "MyClass2"));
            env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(Action<MyClass2>), "Action<MyClass2>"));

            env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(TestDele.myup), "TestDele.myup"));
            env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(TestDele.myup), "TestDele.myup"));
            env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(Action<int>), "Action<int>"));
            env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(Action<int, string>), "Action<int,string>"));

            //统一用make,不管是什么东西
            env.RegType(CSLE.RegHelper_Type.Make(typeof(Action), "Action"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(Color), "Color"));



            env.RegType(CSLE.RegHelper_Type.Make(typeof(Color), "Color"));

            env.RegType(CSLE.RegHelper_Type.Make(typeof(KeyValuePair<,>), "KeyValuePair"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(HashSet<object>), "HashSet<object>"));

            env.RegType(CSLE.RegHelper_Type.Make(typeof(int[]), "int[]"));

            env.RegType(CSLE.RegHelper_Type.Make(typeof(config), "config"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(Math), "Math"));

            env.RegType(CSLE.RegHelper_Type.Make(typeof(Exception), "Exception"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(NotSupportedException), "NotSupportedException"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(NotImplementedException), "NotImplementedException"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(TestClass), "TestClass"));
            env.RegType(CSLE.RegHelper_Type.Make(typeof(StateMgr), "StateMgr"));

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
