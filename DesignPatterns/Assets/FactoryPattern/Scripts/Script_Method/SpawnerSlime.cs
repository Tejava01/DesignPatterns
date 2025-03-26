using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerSlime : SpawnerBase
{
    [SerializeField] private Slime redSlime;
    [SerializeField] private Slime greenSlime;
    [SerializeField] private Slime blueSlime;

    public override MonsterBase SpawnMonster(ColorType type)
    {
        MonsterBase monster = null;

        switch (type)
        {
            case ColorType.red:
                monster = Instantiate(redSlime);
                break;
            case ColorType.green:
                monster = Instantiate(greenSlime);
                break;
            case ColorType.blue:
                monster = Instantiate(blueSlime);
                break;
        }

        monster.SetPosition();
        monster.transform.SetParent(this.transform);

        return monster;
    }
}
