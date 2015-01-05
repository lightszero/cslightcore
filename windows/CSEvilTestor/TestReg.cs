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
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Debug), null));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(testfunc.CSLEConvert), null));

            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(TestDele), null));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Program), null));
            //新的注册方法,参数一样的，
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(MyJson), "MyJson"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(MyJson.JsonNode_ValueNumber), "MyJson.JsonNode_ValueNumber"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(MyJson.IJsonNode), "MyJson.IJsonNode"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(MyJson.JsonNode_ValueString), "MyJson.JsonNode_ValueString"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(MyJson.JsonNode_Object), "MyJson.JsonNode_Object"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(MyJson.JsonNode_Array), "MyJson.JsonNode_Array"));


            //显式区分注册class 和delegate，其实是一码事
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(MyClass2), "MyClass2"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Action<MyClass2>), "Action<MyClass2>"));

            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(TestDele.myup), "TestDele.myup"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(TestDele.myup), "TestDele.myup"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Action<int>), "Action<int>"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Action<int, string>), "Action<int,string>"));

            //统一用make,不管是什么东西
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Action), "Action"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Color), "Color"));



            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Color), "Color"));

            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(KeyValuePair<,>), "KeyValuePair"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(HashSet<object>), "HashSet<object>"));

            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(int[]), "int[]"));

            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(config), "config"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Math), "Math"));

            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(Exception), "Exception"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(NotSupportedException), "NotSupportedException"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(NotImplementedException), "NotImplementedException"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(TestClass), "TestClass"));
            env.RegType(CSLE.RegHelper_Type.MakeType(typeof(StateMgr), "StateMgr"));

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
