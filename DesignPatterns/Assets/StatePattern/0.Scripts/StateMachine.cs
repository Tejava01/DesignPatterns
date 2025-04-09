using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public IState currentState { get; private set; }

    public StateIdle stateIdle;
    public StateMove stateMove;
    public StateJump stateJump;

    public StateMachine(PlayerS player)
    {
        this.stateIdle = new StateIdle(player);
        this.stateMove = new StateMove(player);
        this.stateJump = new StateJump(player);
    }

    //------------------------------------------------------------
    public void InitializeState(IState startState)
    {
        this.currentState = startState;
        startState.Enter();
    }
    public void UpdateState()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }

    public void ChangeState(IState nextState)
    {
        currentState.Exit();
        this.currentState = nextState;
        nextState.Enter();
    }
}
