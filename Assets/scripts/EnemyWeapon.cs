using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : Weapon
{
    protected override void InputHandler()
    {
        if (Input.GetButtonDown("Fire2"))
            Shoot();
    }
}