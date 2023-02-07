using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Cs_CameraController : MonoBehaviour
{
    public bool closeViewModOn;
    public bool isMoving;

    Vector3 eventModCamCoor;
    Vector3 closeViewCamCoor = new Vector3(0, 10f, -12.5f);

   

    public float cameraSpeed;
    GameObject player;

    Shader_handler handler;

    // Start is called before the first frame update
    void Start()
    {
        eventModCamCoor = transform.position;
        closeViewModOn = false;
        isMoving = false;
        cameraSpeed = 12f;
        player = GameObject.FindGameObjectWithTag("PLAYER");

        
        handler = GetComponent<Shader_handler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving&&!closeViewModOn)
        {
            closeViewCamCoor.x = player.transform.position.x;
            transform.position = Vector3.MoveTowards(transform.position, closeViewCamCoor, Time.smoothDeltaTime*cameraSpeed* Vector3.Distance(transform.position, closeViewCamCoor));
            transform.eulerAngles = new Vector3(60+30*((1/( Vector3.Distance(transform.position, closeViewCamCoor)+1))), 0, 0);
          
            if ((Vector3.Distance(transform.position, closeViewCamCoor) < 0.05f))
            {
              //  handler.effectMaterial.SetFloat("_pixels", 1024);
                print(handler.effectMaterial.GetFloat("_pixels"));
                isMoving = false;
                closeViewModOn = true;
            }
        }

        if (isMoving && closeViewModOn)
        {
            print("zoom out");
            transform.position = Vector3.MoveTowards(transform.position, eventModCamCoor, Time.smoothDeltaTime * cameraSpeed*Vector3.Distance(transform.position, eventModCamCoor));
            transform.eulerAngles = new Vector3(60, 0, 0);
          //  handler.effectMaterial.SetFloat("_pixels", 1028);
            if (Vector3.Distance(transform.position,eventModCamCoor)<0.05f)
            {
                isMoving =false;
                closeViewModOn = false;
                
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space)&&!isMoving)
        {
            print("Space");
            if (!isMoving)
            {
                print("zoom in");
                isMoving = true;
            }

        }
    }



    
}
