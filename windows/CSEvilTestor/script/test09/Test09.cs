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
class Love
{
    public int id;
}
class TSave
{
    public string name;
    public int age;
    public Love love;
    public List<Like> like;
    public List<string> strs;
}
class Test09
{
    public Color vv;

    public static void Test()
    {
        MyJson.JsonNode_Object objst =MyJson.Parse
            ("{\"love\":{\"id\":12345}\"name\":\"aname\",\"age\":123,\"like\":[{\"name\":\"aaa\",\"desc\":\"aaaaaa\"},{\"name\":\"bbb\",\"desc\":\"bbbbbb\"}],\"strs\":[\"aa\",\"bb\"]}")
                as MyJson.JsonNode_Object;

        TSave read = CSLEConvert.FromJson("TSave", objst) as TSave;
            
        Debug.Log("read.name=" + read.name);
        Debug.Log("read.like[0].name=" + read.like[0].name);
        Debug.Log("read.strs[1]=" + read.strs[1]);
        Debug.Log("read.love.id=" + read.love.id);
        Debug.Log("write" + CSLEConvert.ToJson(read).ToString());
    }

}

