using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //This is to help create a reference for this script in other scripts
    public static GameManager instance;

    //Retsrating Game once
    private bool gameIsOver = false;

    //Delay before restart
    public float restartDelay = 2.0f;

    //allows other scripts to get use these methods
    private void Awake()
    {
        instance = this;
    }
    //Show game over message and restart game 
    public void EndGame()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
