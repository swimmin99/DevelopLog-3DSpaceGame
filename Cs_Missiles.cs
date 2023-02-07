using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cs_Missiles : MonoBehaviour
{
    public GameObject explosionParticlePrefab;
    Cs_ShipStat playerStat;
    ParticleSystem testParticle = null;
    // Start is called before the first frame update
    void Start()
    {
        testParticle = GetComponent<ParticleSystem>();
        playerStat = GameObject.FindGameObjectWithTag("PLAYERSTAT").GetComponent<Cs_ShipStat>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootMissile();

    }
    
    void ShootMissile()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (testParticle)
            {
                print("fire");
                    testParticle.Play();

            }
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "ASTEROID")
        {
  
            if (explosionParticlePrefab)
            {
                playerStat.resources += 100;

                GameObject explosion = (GameObject)Instantiate(explosionParticlePrefab, other.transform.position, other.transform.rotation);
                Destroy(explosion, explosion.GetComponent<ParticleSystem>().main.startLifetime.constant);
                Destroy(other.gameObject);
                AudioSource.PlayClipAtPoint(Resources.Load("explosion") as AudioClip, transform.position);
            }
        }
    }
}
