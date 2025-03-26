using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonsterBase
{
    [SerializeField] private Vector3 spawnPoint;

    public override void SetPosition()
    {
        this.gameObject.transform.position = spawnPoint;
    }
}
