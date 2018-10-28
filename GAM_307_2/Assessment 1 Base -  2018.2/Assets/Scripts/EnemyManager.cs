using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script for random enemy spawning. Can't stop enemies from spawning on top of each other.
public class EnemyManager : MonoBehaviour {
   // public PlayerHealth playerHealth;
    public GameObject Enemy;
    public float spawnTime = 8f;
    public Transform[] spawnPoints;
    // Use this for initialization
    private void Start()
    {
        //Spawn after a time delay. Want to have enemy spawn after coins collected. No idea how to do at this time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        //if(playerHealth.currentHealth <= 0f)
        //{
        //    return;
        //}
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
