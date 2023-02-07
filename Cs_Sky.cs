using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;


public class Cs_Sky : MonoBehaviour
{
    public GameObject Maincamera, vCam3;
    public bool downright;
    public Vector3 originScale;
    Renderer myRenderer;
    public float speed = 0.4f;
    public float distance;
    Vector3 local;
    // Start is called before the first frame update
    void Start()
    {
        Maincamera = GameObject.Find("Main Camera"); vCam3 = GameObject.Find("CM vcam3");
        distance = Vector3.Distance(Maincamera.transform.position, vCam3.transform.position);
        myRenderer = GetComponent<Renderer>();
        downright = true;
        originScale = transform.localScale;               
        local = transform.localScale;

    }

    // Update is called once per frame

    public void changedownright(bool a)
    {

            downright = a;

    }



    void Update()
    {
        float ofs = speed * Time.time;
        if (downright)
        {
            myRenderer.material.mainTextureOffset = new Vector2(ofs, 0);

        }
        //(ofs)==direction
        else
        {
            Debug.Log(transform.localScale);
            myRenderer.material.mainTextureOffset = new Vector2(0, -ofs);
         /*   if (transform.localScale.x >= 5)
            {
                Maincamera = GameObject.Find("Main Camera"); vCam3 = GameObject.Find("CM vcam3");
                //float speed = Mathf.Lerp(distance, Vector3.Distance(Maincamera.transform.position, vCam3.transform.position), 0.98f);
                Vector3 vec = new Vector3(local.x*Mathf.Sin(Time.smoothDeltaTime), 1, local.z*Mathf.Sin(Time.smoothDeltaTime));
                //Vector3 vec = new Vector3(local.x*speed/distance, 1, local.z*speed/distance);
                transform.localScale = vec;
            }
        */
        
        }


        }

    }


/*       {
                Player = GameObject.FindGameObjectWithTag("Player");
                if (Vector3.Distance(transform.position, Player.transform.position)>100f){
                    transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 10f);
                }*/

