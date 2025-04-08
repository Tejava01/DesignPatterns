using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void Move(Vector3 direction)
    {
        this.transform.position += direction;
    }
}
