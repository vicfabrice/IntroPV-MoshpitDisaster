using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public bool alive;
    public static int health;
    bool beer;
    


    // Use this for initialization
    void Start()
    {

        alive = true;
        health = 30;
        
    }


    // Update is called once per frame
    void Update() {

        CheckIfGameOver();
        
    }

    void CheckIfCrowdIsMortal(){

        int caseSwitch = PeopleController.peopleCant;

        switch (caseSwitch)
        {
            case 12:
                health -= 1;
                break;
            case 15:
                health -= 2;
                break;
            case 16:
                health -= 2;
                break;
            case 17:
                health -= 2;
                break;
            case 18:
                health -= 1;
                break;
            case 20:
                health -= 8;
                break;
            case 25:
                health -= 9;
                break;
            case 26:
                health -= 10;
                break;
            case 30:
                health = 0;
                break;

        }

    }

    public void CheckIfGameOver()
    {
        if(health <= 0)
        {
            alive = false;
            Time.timeScale = 0;
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        /*if(other.gameObject.tag == "Alcohol" && !looping)
        {
            StartCoroutine(CollisionLoop(loopTime));
            Debug.Log("Alcohol coll");
        } else
        {*/
            if(other.gameObject.tag == "People")
            {
                CheckIfCrowdIsMortal();
            }
        //}
    }

    

}
