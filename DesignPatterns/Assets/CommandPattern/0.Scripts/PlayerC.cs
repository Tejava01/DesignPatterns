using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    public void Move(Vector3 direction)
    {
        this.transform.position += direction;
    }
}
