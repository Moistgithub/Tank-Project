using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float MoveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        float leftrightmovement2 = Input.GetAxis("Horizontal2");
    }

    // Update is called once per frame
    void Update()
    {
        float leftrightmovement2 = Input.GetAxis("Horizontal2");

        Vector3 MoveDirection = new Vector3(leftrightmovement2, 0, 0);
        transform.position += MoveDirection * MoveSpeed * Time.deltaTime;
    }
}
