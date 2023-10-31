using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toyota : car
{
        protected override float Speed()
        {
            return speed;
        }
        protected override int EngineCapacity()
        {
            return enginecap;
        }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
