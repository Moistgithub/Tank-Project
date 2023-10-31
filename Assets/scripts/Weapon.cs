using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform firePoint;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
    }
    // Start is called before the first frame update
    private void Update()
    {
        InputHandler();
    }

    protected virtual void InputHandler()
    {

    }

    private void Start()
    {

    }
}
