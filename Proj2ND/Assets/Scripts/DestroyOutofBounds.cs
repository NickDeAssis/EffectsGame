using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float botBound = -5.0f;
    private float leftBound = -24.0f;
    private float rightBound = 24.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < botBound)
        {
            Destroy(gameObject);
        }
    }
}
