﻿using CSEvilTestor;
//using CSEvilTestor;
using System;
using System.Collections.Generic;
using System.Text;

public class ReturnClass
{
    public static ReturnClass ins;
}

public class Block
{
    public Block(string name, int blockType, int inLayer, bool canMove, string imgName)
    {
        blockName = name;
        type = blockType;
        layer = inLayer;
        move = canMove;
        spriteName = imgName;
        Dictionary<int, Action<MyClass2>> dic = new Dictionary<int, Action<MyClass2>>();
        Action<MyClass2> function = Function;
        dic.Add(1, function);
        ReturnClass.ins = FunReturnClas();
    }

    public static void Function(MyClass2 i)
    {
    }

    public static ReturnClass FunReturnClas()
    {
        ReturnClass r = new ReturnClass();
        Debug.Log("====+++++++++++++++");
        return r;
    }

    public string blockName;
    public string spriteName;
    public int type;
    public int layer;
    public bool move;
}
