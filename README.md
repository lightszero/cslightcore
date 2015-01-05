cslightcore
===========
2015-01-05 0.63Beta
    
	修复几处delegate的+=Bug
	修改一些接口名字

2014-12-27 0.62.3Beta

	发现一些定义delegate的+= -=方面的问题，修正
	以及delegate为null时+=的问题，修正
	
2014-12-23 0.62.2Beta

	修改一处ctor阶段表达式识别问题
	
2014-12-23 0.62.1Beta

	修改同一函数付给多个委托的问题
	
2014-12-22 0.62Beta
	
	改写了所有的参数默认值,方便使用monodeveloper把他编译成dll
	
2014-12-22 0.61Beta

	整合了sulbon做了多一些错误提示，和改写了一些冗余的临时变量操作
	增加了新的注册方法，删除了0.60.5的委托注册方式
	    //新的委托注册方法    
		env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(TestDele.myup), "TestDele.myup"));
        env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(Action<int>), "Action<int>"));
        env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(Action<int,string>), "Action<int,string>"));
        env.RegType(CSLE.RegHelper_Type.MakeDelegate(typeof(Action), "Action"));
        //新的类型注册方法
		env.RegType(CSLE.RegHelper_Type.MakeClass(typeof(Color), "Color"));

2014-12-17 0.60.5Beta

    委托注册很多人理解困难，增加一个不那么容易出错的注册工具
	
	    Action<int, string> reg2 = (i, j) => { };//定义一个指定类型的委托，函数是啥不重要，不执行，只抽取参数
        CSLE.RegHelper_Dele_Util.RegWithDelegate(env, reg2, "Action<int,string>");//用这个委托注册

2014-12-08 0.60.3Beta

    修复一处int to enum 的问题
	
	
2014-12-05 0.60.2Beta

    修复一处tokenparser bug，可能导致某些字符串解析时出错

	修复 List[] 索引 不自动转型的问题

2014-12-04 0.60.1Beta
	
	修复这种表达式问题Vector3 vec= new Vector3(1,2,3)*0.5f;
	之前new 之后的不会执行

2014-12-04 0.6Beta

    增加了一个C#Light序列化到Json的例子
	见EvilTestor 用例9
	可以参照此例子建立脚本到数据的映射
	完成协议传输等工作

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


2014-12-03 0.59.1Beta

	追加如下三个默认注册，不用再自行注册
	RegType(new RegHelper_Type(typeof(object),"object"));
	RegType(new RegHelper_Type(typeof(List<>), "List"));
	RegType(new RegHelper_Type(typeof(Dictionary<,>), "Dictionary"));

	修改了一处强制转换表达式识别错误
	
	
2014-12-02 0.59Beta

    修正了 int +String null+string 的问题

    修改了一个机制

    List<ScriptType> （ScriptType是脚本类型） 可以使用了，只需要注册List<>

    其内部会变成List<object>

    但是保证脚本看起来像是把脚本放进了模板元

    见eviltestor用例08

2014-12-02 0.58.1Beta

修正了参数传null无法识别类型的问题


2014-12-02 0.58Beta

修正了模板函数调用的多处错误

泛型函数调用未检查父类型已修正

泛型函数调用时多余的空格导致的识别错误已修正

泛型函数调用参数还是泛型时的识别错误已修正



2014-12-01 0.57.1Beta

Fix 一点小问题

string[] ss = str.Split(new char[]{','});

保证这种char表达式可以正当执行（需要注册char[],string[]）



2014-12-01 0.57Beta

修改了函数调用机制，已经可以处理委托直接作为函数参数输入的情况。

调用函数参数可以自动转型的情况也已经处理。

调用默认参数的情况也已经处理。


2014-12-01 0.56Beta

fix一处优化笔误，get set 出了问题

重写了混乱的委托 -= 的处理


2014-11-29 0.55Beta

加入了表达式缓存，MemberCall调用和StaticCall调用加入了表达式缓存。

多次执行表达式时会极大的提升效率

indexset,indexget，valueget valueset加入了类型缓存

效率都有一定提升


2014-11-17 0.51Beta

允许成员函数和类型重名
修改字符串识别逻辑bug


2014-11-05 0.50Beta

修改了 as 表达式的一些不严谨问题
增加了 is 表达式


2014-10-28 0.49.7Beta

添加了单引号char表达式


2014-10-14 0.49.61Beta

之前的修改导致了bug，换了一种实现方式


2014-10-13 0.49.6Beta

修改了 !表达式 无视运算优先级的bug


2014-10-11 0.49.5Beta【Graphics修改】

加入了ulong


2014-09-29 0.49.4Beta

修正了if(null==xxx)这种表达式
修正了用子类访问父类的静态成员的问题


2014-09-22 0.49.3Beta

结构体没有默认构造函数，修改此问题


2014-09-19

c#light core project
这是将CSLightStudio中的Core部分搬运出来的一个新仓库
因为中国地区访问github太缓慢，clone整个CSLightStudio几乎是不可能的任务
