using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float MoveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        float leftrightmovement = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        float leftrightmovement = Input.GetAxis("Horizontal");

        Vector3 MoveDirection = new Vector3(leftrightmovement, 0, 0);
        transform.position += MoveDirection * MoveSpeed * Time.deltaTime;
    }
}
