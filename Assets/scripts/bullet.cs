using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public int bulletdamage = 2;

    private float speed = 10f;

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

        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject)
        {
            TankHealth something = col.gameObject.GetComponent<TankHealth>();
            if (something == null)
                return;
            something.TakeDamage(bulletdamage);
            Destroy(gameObject);
        }
    }
}
