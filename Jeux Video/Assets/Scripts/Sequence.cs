using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Sequence : Node
{
    Node[] children;
    int index = 0;
    public Sequence(Node[] Children, Conditions[] condition, BehaviorTree BT) : base(condition, BT)
    {
        this.children = Children;
        foreach (Node n in children)
        {
            n.SetParent(this);
        }
    }
    public override void ExecuteAction()
    {
        base.ExecuteAction();
        children[index].ExecuteAction();
    }
    public override void FinishAction(bool result)
    {
        if (!result)
        {
            index = 0;
            base.FinishAction(false);
        }
        else if (index == children.Length - 1)
        {
            index = 0;
            base.FinishAction(true);
        }
        else
        {
            index++;
            children[index].ExecuteAction();
        }
    }
}