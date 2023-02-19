using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Set variables for player Input and player bounds
    public float speed = 15.0f;
    public float horizontalInput;
    public float verticalInput;
    private float xBound = 20.0f;
    private float zTopBound = 16.0f;
    private float zBotBound = -1.0f;
    //private Vector3 lookRight = new Vector3(0, 90, 0);
    //private Vector3 lookLeft = new Vector3(0, 270, 0);
    //private Vector3 lookUp = new Vector3(0, 0, 0);
    //private Vector3 lookDown = new Vector3(0, 180, 0);

    private Vector3 offset = new Vector3(0.0f, 1.5f);

    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get vertical input and use to make play move forward and back z
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);

        //Create player bounds for forward and back
        if (transform.position.z < zBotBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBotBound);
        }
        if (transform.position.z > zTopBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zTopBound );
        }

        // Get hortizontal input and use to make play move left and right z
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        //Create player bounds for left and right
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound,transform.position.y,transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }

        // Input for player to shoot projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Use this if statement to have player shoot/spawn projectile
            Instantiate(projectilePrefab, transform.position +  offset, transform.rotation);
        }

        //We are are trying to make the player face the direction that he had last inputed so we can shoot in all directions.
        //if (horizontalinput > 0)
        //{
        //    transform.rotation = quaternion.euler(lookright);
        //}
        //if (horizontalinput < 0)
        //{
        //    transform.rotation = quaternion.euler(lookleft);
        //}
        //if (verticalinput > 0)
        //{
        //    transform.rotation = quaternion.euler(lookup);
        //}
        //if (verticalinput < 0)
        //{
        //    transform.rotation = quaternion.euler(lookdown);
        //}
        //if (verticalinput == 0)
        //{
        //    transform.rotation = transform.rotation;
        //}
        //if (horizontalinput == 0)
        //{
        //    transform.rotation = transform.rotation;
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Animal")
        {
            LivesManager.instance.TakeDamage();

        }
    }
}
