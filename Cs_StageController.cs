using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cs_StageController : MonoBehaviour
{
    Cs_ShipStat PlayerStat;
    public Transform asteroid;
    public TMP_Text scoreLabel;
    public bool closeViewModOn;
    


    // Start is called before the first frame update
    void Start()
    {
        PlayerStat = GameObject.FindGameObjectWithTag("PLAYERSTAT").GetComponent<Cs_ShipStat>();
    }

    // Update is called once per frame
    void Update()
    {
        MakeAsteroid();
        scoreLabel.text = "population :" + PlayerStat.population +"\nResources :" + PlayerStat.resources + "\nFood" + PlayerStat.food;

       
    }

    void MakeAsteroid()
    {
        if (Random.Range(0, 1000) > 900)
        {
            Instantiate(asteroid);

        } 
    }

    public void EnterCityScene()
    {
        SceneManager.LoadScene("City");
    }


}
