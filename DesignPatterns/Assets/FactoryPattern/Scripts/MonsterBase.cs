using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterBase : MonoBehaviour
{
    private WeaponBase weapon;

    public abstract void SetPosition();
    public void EquipWeapon(WeaponBase weapon)
    {
        this.weapon = weapon;
        weapon.transform.SetParent(this.transform);
    }
}
