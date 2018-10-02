using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    /* Use a coroutine to spawn an enemy at a random location
     * in the game world every second
     * spawn a random enemy as above*/

    /*public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;*/
    public GameObject[] enemies;
    int maxEnemyCount = 10;
    int currentEnemyCount;
    // Use this for initialization
    void Start () {

        currentEnemyCount = 0;
        StartCoroutine (SpawnEnemy());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnEnemy()
    {
        while (currentEnemyCount < maxEnemyCount)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));

            //int rnd = Random.Range(0, enemies.Length);
            // Instantiate(enemies[rnd], spawnPos, transform.rotation);
            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, transform.rotation);
            // Instantiate(Enemy1, spawnPos, transform.rotation);
            //Instantiate(Enemy1, new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10)), Quaternion.identity);
            // Enemy1.transform.position = (new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10)));

            yield return new WaitForSeconds(1);
            currentEnemyCount++;

           // if (currentEnemyCount < maxEnemyCount)
             //   StartCoroutine(SpawnEnemy());
           // else
             //   StopAllCoroutines();
        }
    }
}
