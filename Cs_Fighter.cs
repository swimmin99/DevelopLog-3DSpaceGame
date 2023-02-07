using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cs_Fighter : MonoBehaviour
{
    Rigidbody playerRB;
    Cs_CameraController stat;
    public float speed = 5000.0f;
    float fw = Screen.width * 0.08f;

    
    // Start is called before the first frame update
    void Start()
    {
        
        stat = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Cs_CameraController>();
        playerRB = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveFighter();

        

    }

    void MoveFighter()
    {
        float amtMove = speed * Time.deltaTime;
        //smoothDeltaTime
        float key = Input.GetAxis("Horizontal");
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        if (!stat.closeViewModOn)
        {
            if ((key < 0 && pos.x > fw) || (key > 0 && pos.x < Screen.width - fw))
            {
                // transform.Translate(Vector3.right * amtMove * key, Space.World);
                playerRB.AddForce(Vector3.right * amtMove*key);
            }
        }

       // transform.eulerAngles = new Vector3(0, 0, -key * 20);
    }

   


}
