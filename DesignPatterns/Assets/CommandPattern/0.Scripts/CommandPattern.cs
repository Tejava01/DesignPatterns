using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandPattern : MonoBehaviour
{
    [Header ("CommandInvoker")]
    [SerializeField] private CommandInvoker commandInvoker;
    [Header ("Player")]
    [SerializeField] private Player player;
    [Header("Button")]
    [SerializeField] private Button forwardBtn;
    [SerializeField] private Button backBtn;
    [SerializeField] private Button leftBtn;
    [SerializeField] private Button rightBtn;
    [SerializeField] private Button undoBtn;
    [SerializeField] private Button redoBtn;
    

    private void Start()
    {
        forwardBtn.onClick.AddListener(() => RunPlayerCommand(player, Vector3.forward));
        backBtn.onClick.AddListener(() => RunPlayerCommand(player, Vector3.back));
        leftBtn.onClick.AddListener(() => RunPlayerCommand(player, Vector3.left));
        rightBtn.onClick.AddListener(() => RunPlayerCommand(player, Vector3.right));
        undoBtn.onClick.AddListener(() => commandInvoker.UndoCommand());
        redoBtn.onClick.AddListener(() => commandInvoker.RedoCommand());
    }

    private void RunPlayerCommand(Player player, Vector3 direction)
    {
        ICommand command = new CommandMove(player, direction);
        commandInvoker.ExecuteCommand(command);
    }
}
