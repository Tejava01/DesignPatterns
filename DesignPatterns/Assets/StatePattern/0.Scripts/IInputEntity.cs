using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputEntity
{
    public Vector3 CurrentDirectionInput { get; set; }
    public bool CurrentJumpInput { get; set; }
}
