using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cs_ShipStat : MonoBehaviour
{
    public float population;
    public float resources;
    public float food;



    // Start is called before the first frame update
    void Start()
    {
        population = 10;
        resources = 100;
        food = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(population < food)
        population += (population*0.005f) * (Time.deltaTime/30f);
    }
}
