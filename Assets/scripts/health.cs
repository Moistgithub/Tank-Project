using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private int hp = 10;
    public int Health
    {
        get { return hp;}
        set { hp = value;}
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Object.Destroy(gameObject);
        }
    }
}
