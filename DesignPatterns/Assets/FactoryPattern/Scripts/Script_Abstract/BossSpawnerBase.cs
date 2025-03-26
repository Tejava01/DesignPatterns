using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BossSpawnerBase : MonoBehaviour
{
    public MonsterBase SpawnBoss()
    {
        MonsterBase monster = CreateMonster();
        WeaponBase weapon = CreateWeapon();
        monster.EquipWeapon(weapon);
        monster.SetPosition();
        monster.transform.SetParent(this.transform);
        monster.transform.Translate(0, -2, 0);

        return monster;
    }

    protected abstract MonsterBase CreateMonster();
    protected abstract WeaponBase CreateWeapon();
}
