using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject obstaclePrefab;
    public float minSpawnInterval = 0.5f;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        Invoke("SpawnObjects", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObjects()
    {
        if (playerControllerScript.gameOver == false)
        {
            float newSpawnTime = Random.Range(minSpawnInterval, 3.0f);
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            Invoke("SpawnObjects", newSpawnTime);
        }
    }
}
