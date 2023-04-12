using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private BoxCollider backGroundBC;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        backGroundBC = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - backGroundBC.size.x / 2)
        {
            transform.position = startPos;
        }
    }
}
