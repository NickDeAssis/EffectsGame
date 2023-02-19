using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float resetPosition;
    public float startPosition = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.x;
        resetPosition = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= startPosition - resetPosition)
        {
            //Destroy(gameObject);
            transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
        }
    }
}
