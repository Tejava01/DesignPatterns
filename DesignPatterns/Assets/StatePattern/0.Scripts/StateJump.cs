using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class StateJump : IState
{
    private PlayerS player;

    private bool m_isJumping = false;

    //--------------------------------------
    public StateJump(PlayerS player)
    {
        this.player = player;
    }

    public void Enter()
    {
        

        player.Statetxt.text = "State : Jump";
        player.Rigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
    }

    public void Update()
    {
        if (player.CurrentCollisionType == PlayerS.EPlayerCollisionType.None)
        {
            m_isJumping = true;
        }


        if (m_isJumping)
        {
            if (player.CurrentCollisionType == PlayerS.EPlayerCollisionType.Ground)
            {
                player.stateMachine.ChangeState(player.stateMachine.stateIdle);
            }
        }
    }

    public void Exit()
    {
        m_isJumping = false;
        player.CurrentJumpInput = false;
    }
}
