using System.Threading;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.AI;

public class GoToTarget : Node
{
    Transform target;
    float stoppingDistance;
    NavMeshAgent agent;
    Animator anim;

    public GoToTarget(NavMeshAgent agent, Transform target, float stoppingDistance, Conditions[] conditions, Animator anim, BehaviorTree BT) : base(conditions, BT)
    {
        this.agent = agent;
        this.target = target;
        this.stoppingDistance = stoppingDistance;
        this.anim = anim;
    }

    public override void ExecuteAction()
    {
        if (!EvaluateConditions())
        {
            FinishAction(false);
            return;
        }

        BT.activeNode = this;

        agent.speed = 50f;
        agent.acceleration = 100f;
        agent.angularSpeed = 1000f;
        agent.autoBraking = false;

        agent.SetDestination(target.position);

        if (anim != null)
            anim.SetBool("isSwimming", true);
    }

    public override void Tick(float deltaTime)
    {
        if (!agent.pathPending && agent.remainingDistance <= stoppingDistance)
        {
            FinishAction(true);
        }
    }

    public override void FinishAction(bool result)
    {
        if (anim != null)
            anim.SetBool("isSwimming", false);

        agent.SetDestination(agent.transform.position);
        base.FinishAction(result);
    }

    public override void Interrupt()
    {
        agent.SetDestination(agent.transform.position);
        base.Interrupt();
    }
}