using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Needed to add this UI stuff to be able to have use the UI stuff
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentFedAmount = 0;
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
    }

    public void FeedAnimal(int amount)
    {

        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {           
            Debug.Log(currentFedAmount);
            ScoreManager.instance.AddPoint(amountToBeFed);
            //scoreManager.AddPoint(amountToBeFed);
            Destroy(gameObject);
        }

    }
}
