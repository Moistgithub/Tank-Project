using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TankHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 10;
    public int CurrentHealth;
    public ScoreManager scoremanager;

    void Start()
    {
        CurrentHealth = maxHealth;
        scoremanager = FindObjectOfType<ScoreManager>();
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnDestroy()
    {
        if(gameObject.CompareTag("Player"))
        {
            FindObjectOfType<spawner>().RespawnHank();
            scoremanager.villainscore++; 
        }
        if(gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<spawner>().RespawnVillain();
            scoremanager.score++;
        }


    }
}
