using System;
using UnityEngine;

public class BehaviourTreeRunner : MonoBehaviour
{
    private BehaviourTree _tree;

    private void Start()
    {
        _tree = ScriptableObject.CreateInstance<BehaviourTree>();
        var log = ScriptableObject.CreateInstance<DebugLogNode>();
        log.message = "Hellow World";
        _tree._rootNode = log;
    }

    private void Update()
    {
        _tree.Update();
    }
}