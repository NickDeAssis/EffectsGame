using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    public static LivesManager instance;

    public Text livesText;

    private int lives = 3;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

    // Update is called once per frame
    public void TakeDamage()
    {
        lives--;
        livesText.text = "Lives: " + lives.ToString();
        if(lives == 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
