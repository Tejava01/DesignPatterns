using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnerMushroom : BossSpawnerBase
{
    [Header("Monster")]
    [SerializeField] private Mushroom mushroom;

    [Header("Weapon")]
    [SerializeField] private WeaponSword sword;
    [SerializeField] private WeaponSpear spear;
    [SerializeField] private WeaponMace mace;

    private System.Random random = new System.Random();

    protected override MonsterBase CreateMonster()
    {
        MonsterBase monster = Instantiate(mushroom);

        return monster;
    }

    protected override WeaponBase CreateWeapon()
    {
        int index = random.Next(3);
        
        WeaponBase weapon = null;

        switch (index)
        {
            case 0:
                weapon = Instantiate(sword);
                break;
            case 1:
                weapon = Instantiate(spear);
                break;
            case 2:
                weapon = Instantiate(mace);
                break;
        }

        return weapon;
    }
}
