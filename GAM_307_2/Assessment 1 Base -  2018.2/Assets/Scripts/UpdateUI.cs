﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour {

    [SerializeField]
    private Text timerLabel;

    [SerializeField]
    private Text coinsLabel;

    [SerializeField]
    private Text healthLabel;

    public GameObject wonGamePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerLabel.text = FormatTime(GameManager.Instance.TimeRemaining);
        coinsLabel.text = GameManager.Instance.NumCoins.ToString();
        healthLabel.text = FormatHealth(GameManager.Instance.GetPlayerHealthPercentage());
	}

    private string FormatTime(float timeInSeconds)
    {
        return string.Format("{0}:{1:00}", Mathf.FloorToInt (timeInSeconds/60), Mathf.FloorToInt(timeInSeconds % 60));
    }

    private string FormatHealth(float healthPercentage)
    {
        return string.Format("{0}%", Mathf.RoundToInt (healthPercentage * 100));
    }
}
