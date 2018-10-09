using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

    private float _timeRemaining;

 private float maxTime = 2 * 60; //in seconds

    private int maxHealth = 5;

    private int _numCoins;

    public int NumCoins
    {
        get { return _numCoins; }
        set { _numCoins = value; }
    }

    private float _playerHealth;

    public float PlayerHealth
    {
        get { return _playerHealth; }
        set { _playerHealth = value; }
    }


    public float TimeRemaining
    {
        get { return _timeRemaining; }
        set { _timeRemaining = value; }

    }

    private void OnEnable()
    {
        DamagePlayerEvent.OnDamagePlayer += DecrementPlayerHealth;
    }

    private void OnDisable()
    {
        DamagePlayerEvent.OnDamagePlayer -= DecrementPlayerHealth;
    }
    // Use this for initialization
    void Start () {
        TimeRemaining = maxTime;
        PlayerHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		TimeRemaining -= Time.deltaTime;

        if (TimeRemaining <= 0)
        {
            Restart();
        }
    
	}

    private void DecrementPlayerHealth (GameObject player)
    {
        PlayerHealth--;

        if (PlayerHealth <= 0)
        {
            Restart();//Restart game
        }
    }

   public void Restart()
    {
      
        {
            Application.LoadLevel(Application.loadedLevel);
            TimeRemaining = maxTime;
            PlayerHealth = maxHealth;
        }
    }
}
