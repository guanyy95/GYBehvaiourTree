using System.Collections;
using System.Collections.Generic;
using BT;
using UnityEngine;

public class MovementAITree : BTTree
{
    private BTNode _root;
    protected override void Init()
    {
        base.Init();
        _root = new BTPrioritySelector();

        BTParallel running = new BTParallel(BTParallel.ParallelFunction.Or);
        _root.AddChild(running);
    }
}
