using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnTimer = 2.0f;
    public float spawnIntervalMin = 1.0f;
    public Vector3 spawnPositionX = new Vector3(10.0f,0,0);
    private Vector3 spawnRotation = new Vector3(0, 0, 0);
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        SpawnObstacle();       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstacle, spawnPositionX, Quaternion.Euler(spawnRotation));

            float newSpawnTimer;
            newSpawnTimer = Random.Range(spawnIntervalMin, 3.0f);
            Invoke("SpawnObstacle", newSpawnTimer);
        }

    }
}
