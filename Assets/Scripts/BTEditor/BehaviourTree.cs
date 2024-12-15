using UnityEngine;

[CreateAssetMenu()]
public class BehaviourTree : ScriptableObject
{
    public Node _rootNode;
    private Node.State _treeState = Node.State.Running;

    public Node.State Update()
    {
        if (_rootNode.state == Node.State.Running)
        {        
            _treeState =  _rootNode.Update();
        }

        return _treeState;
    }
}