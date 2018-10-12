using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{

    public int stage;
    public int pHealth;
    public string moshpitLevel;

    // Use this for initialization
    void Start()
    {

        pHealth = PlayerController.health;
        moshpitLevel = PeopleController.peopleLevel;

    }

    // Update is called once per frame
    void Update()
    {
        pHealth = PlayerController.health;
        moshpitLevel = PeopleController.peopleLevel;
    }

    //checks for entering a trigger
    void OnCollisionEnter2D(Collision2D other)
    {
        //checks other collider's tag
        if (other.gameObject.tag == "Player")
        {
            stage += 10;
            AlcoholZone.drunkText.text = "Great! Time to go home";


        }
    }
}
