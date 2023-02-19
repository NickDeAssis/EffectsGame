using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float minSpeed = 5.0f;
    public float maxSpeed = 25.0f;
    public float speed = 10.0f;
    private PlayerController  playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        if (gameObject.tag == "Obstacle")
        {
            speed = Random.Range(minSpeed, maxSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
