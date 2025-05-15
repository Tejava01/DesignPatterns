using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMove : IState
{
    private PlayerS player;

    //---------------------------------------------------------
    public StateMove(PlayerS player)
    {
        this.player = player;
    }

    public void Enter()
    {
        player.Statetxt.text = "State : Move";
    }

    public void Update()
    {
        player.transform.Translate(player.CurrentDirectionInput * 0.01f);

        if (player.CurrentDirectionInput == Vector3.zero)
        {
            player.stateMachine.ChangeState(player.stateMachine.stateIdle);
        }

        if (player.CurrentJumpInput == true)
        {
            player.stateMachine.ChangeState(player.stateMachine.stateJump);
        }
    }

    public void Exit()
    {

    }
}
