using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleController : MonoBehaviour {

    //public float speed = 8f;
    public static int peopleCant;
    private GameObject[] people;
    public static string peopleLevel;

    // Use this for initialization
    void Start () {

        people = GameObject.FindGameObjectsWithTag("People");
        peopleCant = people.Length;
        //peopleLevel = "is ok";
}
	
	// Update is called once per frame
	void Update () {
        SetMoshpitLevel();
        SetAdvertencia();
        //Debug.Log(peopleLevel + "plusone");
    }


    public void PlusOnePeopleLenght()
    {
        peopleCant++;
        SetMoshpitLevel();
        
    }

    void SetMoshpitLevel()
    {
        int caseSwitch = peopleCant;

        switch (caseSwitch)
        {
            case 12:
                peopleLevel = "is ok";
                break;
            case 15:
                peopleLevel = "is growing";
                break;
            case 16:
                peopleLevel = "is growing";
                break;
            case 17:
                peopleLevel = "is growing fast!";
                break;
            case 18:
                peopleLevel = "is crowded. Danger!";
                break;
            case 20:
                peopleLevel = "is dense. Hurry up!";
                break;
            case 25:
                peopleLevel = "is dense. Hurry up!";
                break;

        }
    }

    void SetAdvertencia()
    {
        if(peopleCant > 20)
        {
            AlcoholZone.drunkText.text = "Go home dude!";
        }
    }


}
