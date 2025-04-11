using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IInputEntity
{
    public bool IsInputLock {  get; set; }
    public Vector3 CurrentDirectionInput { get; set; }
    public bool CurrentJumpInput { get; set; }
}

//PlayerINput 받는 부분
public class StatePattern : MonoBehaviour
{
    [Header("InputEntity")]
    [SerializeField] private IInputEntity m_inputEntity;

    //---------------------------------------------
    private void Awake()
    {
        m_inputEntity = this.GetComponent<IInputEntity>();

        if(m_inputEntity == null)
        {
            //ERROR!
        }
    }

    private void Update()
    {
        if (m_inputEntity == null)
            return;

        if (Input.GetKey(KeyCode.W))
        {
            m_inputEntity.CurrentDirectionInput = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            m_inputEntity.CurrentDirectionInput = Vector3.back;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_inputEntity.CurrentDirectionInput = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            m_inputEntity.CurrentDirectionInput = Vector3.right;
        }
        else
        {
            m_inputEntity.CurrentDirectionInput = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_inputEntity.CurrentJumpInput = true;
        }
    }
}
