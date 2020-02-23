using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour
{

    //public Transform SpawnPoint;
    public GameObject enemyPrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }

    /*
    void Upate() {

        elapsedTime += Time.deltaTime;

        if (elapsedTime > seconsbetweenSpawn)
        {
            elapsedTime = 0;

            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);

            
        }
        */
     //   do {
      //      GameObject enemy = Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
     //      } while (enmCnt < 4);
        //creates the enemy
        //instantiates the enemy prefab on the pos and rot efined by spawn point
        //now it can be use as variable

        /* try using delta time to set the timer for respawn delay and list / count for keepingit from respawning infinitly */
       

    
}
