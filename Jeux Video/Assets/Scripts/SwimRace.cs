using UnityEngine;
using UnityEngine.AI;

public class SwimRace : BehaviorTree
{
    [SerializeField] Transform[] targets;
    [SerializeField] Animator anim;

    Interrupt interrupt;
    protected override void InitializeTree()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        GoToTarget goTo1 = new GoToTarget(agent, targets[0], 2, null, anim, this);
        Wait wait1 = new Wait(2, null, this);
        GoToTarget goTo2 = new GoToTarget(agent, targets[1], 2, null, anim, this);

        root = new Sequence(new Node[] { goTo1, wait1, goTo2 }, null, this);

        //interrupt = new Interrupt(null, this);
    }

    private void OnDisable()
    {
        interrupt.Stop();
    }

    private void OnEnable()
    {
        if (interrupt != null)
            interrupt.Start();
    }
}