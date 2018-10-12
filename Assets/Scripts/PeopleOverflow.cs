using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleOverflow : MonoBehaviour {

    public float spawnRate = 5; //rate at which enemies spawn
    public GameObject peopleN;    //enemy prefab

    //bounds of spawner
    public float leftBound = -7F;
    public float rightBound = 7F;
    // Use this for initialization

    void Start () {
        //call SpawnEnemy based on spawnRate
        InvokeRepeating("SeVaLlenando", 5, spawnRate);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SeVaLlenando()
    {
        GameObject peopleClone;      //a clone of the enemy prefab
        peopleClone = Instantiate(peopleN, this.transform.position, this.transform.rotation) as GameObject;        //spawns enemyClone at this location and rotation
        peopleClone.gameObject.SendMessage("PlusOnePeopleLenght");

        //randomly moves spawner along x axis
        float x = Random.Range(leftBound, rightBound);
        transform.position = new Vector3(x, this.transform.position.y, 0);
    }
}
