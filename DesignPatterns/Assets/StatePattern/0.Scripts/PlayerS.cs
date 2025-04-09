using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerS : MonoBehaviour, IInputEntity
{
    public enum EPlayerCollisionType
    {
        None = 0,
        Ground = 1,
    }

    //----------------------------------------------
    public StateMachine stateMachine { get; private set; }

    public Rigidbody Rigidbody;
    public Text Statetxt;

    private Vector3 m_vecCurInput = Vector3.zero;
    private bool m_isInputLock = false;
    private bool m_jumpInput = false;

    //-----------------------------------------------------------------
    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
        stateMachine = new StateMachine(this);
    }

    private void Start()
    {
        stateMachine.InitializeState(stateMachine.stateIdle);
    }

    private void Update()
    {
        stateMachine.UpdateState();
    }

    //-----------------------------------------------------------------
    public bool IsInputLock { get => m_isInputLock; set => m_isInputLock = value; }

    public Vector3 CurrentDirectionInput { get => m_vecCurInput; set => m_vecCurInput = value; }
    public bool CurrentJumpInput { get => m_jumpInput; set => m_jumpInput = value; }

    public EPlayerCollisionType CurrentCollisionType { get; private set; } = EPlayerCollisionType.None;

    //-----------------------------------------------------------------

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") == true)
        {
            Debug.Log("Ground");
            CurrentCollisionType = EPlayerCollisionType.Ground;
            return;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("EXIT");
        CurrentCollisionType = EPlayerCollisionType.None;
    }

}
