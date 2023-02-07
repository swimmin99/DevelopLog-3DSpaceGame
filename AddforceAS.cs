using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddforceAS : MonoBehaviour
{
    Rigidbody RB;
    float forceMultiplier = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.back * forceMultiplier);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
