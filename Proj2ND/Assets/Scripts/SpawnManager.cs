using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float spawnRangeX = 20.0f;
    public float spawnPosZ = 18.0f;
    public float spawnRangeTopZ = 16.0f;
    public float spawnRangeBotZ = -1.0f;
    public float spawnPosLeftX = -22.0f;
    public float spawnPosRightX = 22.0f;
    private Vector3 spawnRotationLeftX =new Vector3(0,90,0);
    private Vector3 spawnRotationRightX = new Vector3(0,270,0);
    private Vector3 spawnRotationTopX = new Vector3(0, 180, 0);



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        //generate a random number within the array range to spawna  random animal in that array for each direct
        int animalIndexTop = Random.Range(0, animalPrefab.Length);
        int animalIndexLeft = Random.Range(0, animalPrefab.Length);
        int animalIndexRight = Random.Range(0, animalPrefab.Length);

        //Creating a spawn position at a random x cordinate between the X spawn range in the top spanwer
        Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Spawn a random animal at the Top Spawner
        Instantiate(animalPrefab[animalIndexTop], spawnPosTop, Quaternion.Euler(spawnRotationTopX));

        //Creating a spawn position at a random Z cordinate between the Z spawn range in the Left spanwer
        Vector3 spawnPosLeft = new Vector3( spawnPosLeftX, 0, Random.Range(spawnRangeBotZ, spawnRangeTopZ));

        //Spawn a random animal at the Left Spawner
        Instantiate(animalPrefab[animalIndexLeft], spawnPosLeft, Quaternion.Euler(spawnRotationLeftX));

        //Creating a spawn position at a random Z cordinate between the Z spawn range in the Right spanwer
        Vector3 spawnPosRight = new Vector3(spawnPosRightX, 0, Random.Range(spawnRangeBotZ, spawnRangeTopZ));

        //Spawn a random animal at the Left Spawner
        Instantiate(animalPrefab[animalIndexRight], spawnPosRight, Quaternion.Euler(spawnRotationRightX));
    }
}
