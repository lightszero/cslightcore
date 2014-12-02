using CSEvilTestor;
//using CSEvilTestor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

class T04
{
    public void Test()
    {
        Debug.Log("tcall:" + name);
    }
    public string name;
}
class Test08
{
    public Color vv;

    public static void F()
    {
        Test08 tt = new Test08();
        tt.vv = Color.FromArgb(1);
        
        tlist = new List<T04>();
        tlist.Add(new T04());
        tlist[0].name="cool";
        tlist.Add(new T04());
        tlist[1].name = "fuck";
        Debug.Log("tt:"+tlist[0].name);
        tlist[1].Test();
    }
    /// <summary>
    /// T04 
    /// </summary>
    static List<T04> tlist;
}
