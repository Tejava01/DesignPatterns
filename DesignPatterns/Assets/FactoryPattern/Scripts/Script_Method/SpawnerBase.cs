using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorType
{
    red,
    green,
    blue,
}

public abstract class SpawnerBase : MonoBehaviour
{
    public abstract MonsterBase SpawnMonster(ColorType type);
}
