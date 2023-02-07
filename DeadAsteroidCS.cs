using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadAsteroidCS : MonoBehaviour
{
    public float pastTime = 0f;
    float endofWaitTime = 1f;
    public bool starttimer;
    // Start is called before the first frame update
    void Start()
    { 
        starttimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        pastTime += Time.deltaTime;

        if (pastTime > endofWaitTime)
        {


            Destroy(gameObject);

        }
    }
}
