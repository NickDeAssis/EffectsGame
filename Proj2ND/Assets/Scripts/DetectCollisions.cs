using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Animal")
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }

    //public void FullAnimal()
    //{
    //    void  OnTriggerEnter(Collider other)
    //    {
    //        if (other.gameObject.tag == "Animal")
    //        {
    //            other.GetComponent<AnimalHunger>().FeedAnimal(1);
    //            Destroy(gameObject);
    //            //Destroy(other.gameObject);
    //        }
    //    }

    //}
}
