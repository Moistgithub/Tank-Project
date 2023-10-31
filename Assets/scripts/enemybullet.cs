using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 10;
    public int acceleration = 10;
    public int bulletdamage = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        if (rb == null) return;
        //rb.velocity = new Vector2(speed, 0) * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<TankHealth>().TakeDamage(bulletdamage);
            Destroy(gameObject);
        }
    }
}

