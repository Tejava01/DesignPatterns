using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandMove : ICommand
{
    private PlayerC m_player;
    private Vector3 m_direction;

    public CommandMove(PlayerC player, Vector3 direction)
    {
        m_player = player;
        m_direction = direction;
    }

    public void Execute()
    {
        m_player.Move(m_direction);
    }

    public void Undo()
    {
        m_player.Move(-m_direction);
    }
}
