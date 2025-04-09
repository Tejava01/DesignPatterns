using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : IState
{
    private PlayerS player;

    public StateIdle(PlayerS player)
    {
        this.player = player;
    }

    public void Enter()
    {
        player.Statetxt.text = "State : Idle";
    }

    public void Update()
    {
        if (player.CurrentDirectionInput != Vector3.zero)
        {
            player.stateMachine.ChangeState(player.stateMachine.stateMove);
        }

        if(player.CurrentJumpInput == true)
        {
            player.stateMachine.ChangeState(player.stateMachine.stateJump);
        }
    }

    public void Exit()
    {
    }
}
