using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody playerRb;
    private float zBoundTop = 9.0f;
    private float zBoundBot = -9.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ConstrainPlayerPosition();
        MovePlayer();
    }

    void MovePlayer()
    {
        if (transform.position.z > zBoundTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundTop);
        }

        if (transform.position.z < zBoundBot)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundBot);
        }
    }
    void ConstrainPlayerPosition()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
}
