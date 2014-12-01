cslightcore
===========
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
