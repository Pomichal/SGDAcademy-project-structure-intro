using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{

    protected Veggie veggie;

    public State(Veggie stateMachine)
    {
        veggie = stateMachine;
    }

    public virtual void Enter()
    {

    }

    public virtual void Exit()
    {

    }

    public virtual void UpdateState()
    {
        Debug.Log("Update state");

    }
}
