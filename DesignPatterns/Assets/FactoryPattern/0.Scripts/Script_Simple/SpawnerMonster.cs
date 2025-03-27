using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EMonsterType
{
    Slime,
    Mushroom,
}

public class SpawnerMonster : MonoBehaviour
{
    [SerializeField] private Slime slime;
    [SerializeField] private Mushroom mushroom;

    public MonsterBase SpawnMonster(EMonsterType type)
    {
        MonsterBase monster = null;

        switch (type)
        {
            case EMonsterType.Slime:
                monster = Instantiate(slime);
                break;
            case EMonsterType.Mushroom:
                monster = Instantiate(mushroom);
                break;
        }

        monster.SetPosition();
        monster.transform.SetParent(this.transform);

        return monster;
    }
}
