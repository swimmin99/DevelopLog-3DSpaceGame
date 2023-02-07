using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cs_Asteroid : MonoBehaviour
{
    public GameObject explosionParticlePrefab;

    float speed;
    int rotX, rotY, rotZ;
    public GameObject DeadAsteroid;
    Cs_Fighter_Collision collidedComponenet;
    int HP;

    Renderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        collidedComponenet = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Cs_Fighter_Collision>();
        myRenderer = GetComponent<Renderer>();

        initAsteroid();
    }

    // Update is called once per frame
    void Update()
    {
        float amtMove = speed * Time.deltaTime;
        transform.Rotate(new Vector3(rotX, rotY, rotZ)*Time.smoothDeltaTime);
        transform.Translate(Vector3.back * amtMove, Space.World);

        if (transform.position.z < -30)
        {
            Destroy(gameObject);
        }
    }

    void initAsteroid()
    {
        float sizeX = Random.Range(80f, 100f);
        float sizeY = Random.Range(80f, 100f);
        float sizeZ = Random.Range(80f, 100f);

        transform.localScale = new Vector3(sizeX, sizeY, sizeZ);


        float r = Random.Range(0.6f, 1.0f);
        myRenderer.material.color = new Vector4(r, 0.8f, 0.8f, 1);

        //spped and hp
        speed = Random.Range(10, 20);
        HP = Random.Range(0, 5);

        //rotation
        rotX = Random.Range(-90, 90);
        rotY = Random.Range(-90, 90);
        rotZ = Random.Range(-90, 90);

        //운석 초기 위치
        float x = Random.Range(-28, 28);
        float z = Random.Range(37, 45);
        //
       // float y = 4;
        //
        transform.position = new Vector3(x, 5, z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = (GameObject)Instantiate(explosionParticlePrefab, transform.position, transform.rotation);
        Destroy(explosion, explosion.GetComponent<ParticleSystem>().main.startLifetime.constant);
        AudioSource.PlayClipAtPoint(Resources.Load("explosion") as AudioClip, transform.position);
        collidedComponenet.CollisionCall();
        Instantiate(DeadAsteroid, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
