using System;
using System.Diagnostics;
using UnityEngine;

public abstract class Node
{
    protected Node parent;
    protected BehaviorTree BT;
    protected Conditions[] conditions;
    protected bool interupted = false;

    public Node(Conditions[] conditions, BehaviorTree BT)
    {
        this.BT = BT;
        this.conditions = conditions;
    }

    public Node()
    {
    }

    public void SetParent(Node parent)
    {
        this.parent = parent;
    }

    public bool EvaluateConditions()
    {
        if (conditions == null)
            return true;

        foreach (Conditions c in conditions)
        {
            if (!c.Evaluate())
                return false;
        }
        return true;
    }

    virtual public void ExecuteAction()
    {
        if (!EvaluateConditions())
        {
            FinishAction(false);
            return;
        }

        BT.activeNode = this;
    }

    virtual public void Tick(float deltaTime)
    {

    }

    virtual public void FinishAction(bool result)
    {
        if (parent != null)
            parent.FinishAction(result);
        else
            BT.EvaluateTree();
    }

    virtual public void Interrupt()
    {
        if (parent != null)
            parent.Interrupt();
    }



}
