using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private PlayerController playerControllerScript;
    
    public float minSpawnInterval = 0.5f;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private int randomObstacle;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        Invoke("SpawnObjects", 5.0f);
        Debug.Log(playerControllerScript.gameOver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObjects()
    {
        if (playerControllerScript.gameOver == false)
        {
            randomObstacle = Random.Range(0, obstaclePrefabs.Length);
            float newSpawnTime = Random.Range(minSpawnInterval, 3.0f);
            Instantiate(obstaclePrefabs[randomObstacle], spawnPos, obstaclePrefabs[randomObstacle].transform.rotation);
            Invoke("SpawnObjects", newSpawnTime);
        }
    }
}
