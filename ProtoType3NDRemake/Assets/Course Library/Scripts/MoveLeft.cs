using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            if (playerControllerScript.doubleSpeed)
            {
                transform.Translate(Vector3.left * (speed * 2) * Time.deltaTime);
            }else
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }

        if (gameObject.transform.position.x < -10 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
