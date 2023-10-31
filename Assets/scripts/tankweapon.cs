using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankweapon : Weapon
{
    protected override void InputHandler()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
}
