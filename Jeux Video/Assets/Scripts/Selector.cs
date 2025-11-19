using UnityEngine;

public class Selector : Node
{
    Node[] children;
    int index = 0;

    public Selector(Node[] Children, Conditions[] condition, BehaviorTree BT) : base(condition, BT)
    {
        this.children = Children;
        foreach (Node child in children)
        {
            child.SetParent(this);
        }
    }
    public override void ExecuteAction()
    {
        base.ExecuteAction();
        children[index].ExecuteAction();
    }
    public override void FinishAction(bool result)
    {
        if (result)
        {
            index = 0;
            base.FinishAction(true);
        }
        else if (index == children.Length - 1)
        {
            index = 0;
            base.FinishAction(false);
        }
        else
        {
            index++;
            children[index].ExecuteAction();
        }
    }
}