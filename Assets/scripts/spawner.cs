using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
    public GameObject HankTheTank;
    public GameObject villain;
    public Vector3 spawnpointHank;
    public Vector3 spawnpointVillain;

    // Start is called before the first frame update
    void Start()
    {
        RespawnHank();
        RespawnVillain();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnHank()
    {
        Instantiate(HankTheTank, spawnpointHank, Quaternion.identity);
    }
    public void RespawnVillain()
    {
        Instantiate(villain, spawnpointVillain, Quaternion.Euler(0,0,180));
    }
}
