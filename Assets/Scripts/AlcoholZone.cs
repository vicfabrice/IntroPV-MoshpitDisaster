using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlcoholZone : MonoBehaviour {

        public static int alcoholCant;
        private GameObject[] alcohol;

        bool looping = false;
        public int loopTime;

        public static Text drunkText;


    // Use this for initialization
    void Start () {

        alcohol = GameObject.FindGameObjectsWithTag("Alcohol");
        alcoholCant = alcohol.Length;
        looping = false;
        loopTime = 8;
        drunkText = GameObject.Find("DrunkText").GetComponent<Text>();
        drunkText.text = "Take a beer dude!";

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(CollisionLoop(loopTime));
         }
    }

    IEnumerator CollisionLoop(int loopLength)
    {
        float i = 0;
        looping = true;
        drunkText.text = "DRUNK";

        while (i <= loopLength)
        {
            PlayerMobility.Escabio();
            i += Time.deltaTime;
            //add 1 frame's length to i.
            yield return null;
            //wait one frame
        }
        looping = false;
        drunkText.text = "Come to the stage!";

    }
}
