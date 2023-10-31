using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damager : health
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log("colliding");
            health EnemyHealth = collision.collider.GetComponent<health>();
            EnemyHealth.Health -= 2;
            
        }
    }
}
