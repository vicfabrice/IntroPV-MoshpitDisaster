using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        //checks other collider's tag
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Win", LoadSceneMode.Single);
            Time.timeScale = 0;          //Destroy(gameObject.tag);              //destroys other collider's gameobject
        }

    }
}
