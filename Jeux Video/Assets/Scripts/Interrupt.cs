using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class Interrupt
{
    Conditions[] conditions;
    BehaviorTree BT;
    bool[] conditionState;

    CancellationTokenSource cts;

    float cooldown;
    float lastInterruptTime = -10f;

    public Interrupt(Conditions[] conditions, BehaviorTree BT)
    {
        this.conditions = conditions;
        this.BT = BT;
        conditionState = new bool[conditions.Length];

        Start();
    }

    async private void CheckConditions(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            for (int index = 0; index < conditions.Length; index++)
            {
                bool current = conditions[index].Evaluate();

                if (!conditionState[index] && current)
                {
                    if (Time.time - lastInterruptTime >= cooldown)
                    {
                        lastInterruptTime = Time.time;
                        BT.Interupt();
                    }
                    UpdateState();
                    break;
                }

                conditionState[index] = current;
            }
            await Task.Delay(100);
        }
    }

    private void UpdateState()
    {
        for (int i = 0; i < conditions.Length; i++)
        {
            conditionState[i] = conditions[i].Evaluate();
        }
    }

    public void Start()
    {
        cts = new CancellationTokenSource();
        UpdateState();
        CheckConditions(cts.Token);
    }

    public void Stop()
    {
        cts.Cancel();
    }
}