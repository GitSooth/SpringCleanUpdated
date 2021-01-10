using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTCondiccao : DTNode
{
    private DTNode trueChild, falseChild;
    private Func<bool> condition;

    public DTCondiccao(Func<bool> condition, DTNode tChild, DTNode fChild)
    {
        this.condition = condition;
        trueChild = tChild;
        falseChild = fChild;
    }


    public override void Run()
    {
        if (condition()) trueChild.Run();
        else falseChild.Run();
    }
}