using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMushroom : SpawnerBase
{
    [SerializeField] private Mushroom redMushroom;
    [SerializeField] private Mushroom greenMushroom;
    [SerializeField] private Mushroom blueMushroom;

    public override MonsterBase SpawnMonster(ColorType type)
    {
        MonsterBase monster = null;

        switch (type)
        {
            case ColorType.red:
                monster = Instantiate(redMushroom);
                break;
            case ColorType.green:
                monster = Instantiate(greenMushroom);
                break;
            case ColorType.blue:
                monster = Instantiate(blueMushroom);
                break;
        }

        monster.SetPosition();
        monster.transform.SetParent(this.transform);

        return monster;
    }
}
