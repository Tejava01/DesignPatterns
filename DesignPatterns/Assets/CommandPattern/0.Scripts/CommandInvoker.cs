using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    private Stack<ICommand> m_stackUndo = new Stack<ICommand>();
    private Stack<ICommand> m_stackRedo = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        m_stackUndo.Push(command);
        m_stackRedo.Clear();
    }

    public void UndoCommand()
    {
        if(m_stackUndo.Count > 0)
        {
            ICommand activeCommand = m_stackUndo.Pop();
            m_stackRedo.Push(activeCommand);
            activeCommand.Undo();
        }
    }

    public void RedoCommand()
    {
        if(m_stackRedo.Count > 0)
        {
            ICommand activeCommand = m_stackRedo.Pop();
            m_stackUndo.Push(activeCommand);
            activeCommand.Execute();
        }
    }
}
