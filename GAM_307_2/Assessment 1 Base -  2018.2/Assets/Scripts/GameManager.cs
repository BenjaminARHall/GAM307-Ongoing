using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

    private float _timeRemaining;

    private float maxTime = 2 * 60; //in seconds

    public float TimeRemaining
    {
        get { return _timeRemaining; }
        set { _timeRemaining = value; }

    }

	// Use this for initialization
	void Start () {
        TimeRemaining = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		TimeRemaining -= Time.deltaTime;

        if (TimeRemaining <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
            TimeRemaining = maxTime;
        }
	}
}
