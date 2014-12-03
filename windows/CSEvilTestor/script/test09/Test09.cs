using CSEvilTestor;
using CSEvilTestor.testfunc;
//using CSEvilTestor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


class Like
{
    public string name;
    public string desc;
}
class TSave
{
    public string name;
    public int age;
    public List<Like> like = new List<Like>();
}
class Test09
{
    public Color vv;

    public static void Test()
    {
        TSave read = CSLEConvert.FromJson("TSave", "{\"name\":\"aaa\",\"age\":123,\"like\":[{\"name\":\"aaa\",\"desc\":\"aaaaaa\"},{\"name\":\"bbb\",\"desc\":\"bbbbbb\"}]}")
            as TSave;

        Debug.Log("read" + read.name);
        Debug.Log("write" + CSLEConvert.ToJson(read));
    }

}
