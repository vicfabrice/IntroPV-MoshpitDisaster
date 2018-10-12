using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUpdater : MonoBehaviour {

    public PointCounter pointCounter;

    public Text statusText;

    public Text moshpitText;

    public String pplLevel;

    // Use this for initialization
    void Start()
    {
        statusText = GameObject.Find("ScoreText").GetComponent<Text>();
        moshpitText = GameObject.Find("MoshpitText").GetComponent<Text>();
        
        
        statusText.text = "Stage: 0 Health: 20";
        moshpitText.text = "Moshpit is ok";
    }

    // Update is called once per frame
    void Update()
    {
        
        statusText.text = "Stage: " + pointCounter.stage.ToString() + " Health: " + pointCounter.pHealth.ToString();

        moshpitText.text = "Moshpit " + pointCounter.moshpitLevel;

    }
}
