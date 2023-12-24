using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTwo : MonoBehaviour
{
    public void ExitButton()
    {
        //Once Exit button is pressed it closes game
        Application.Quit();
        //Writes Game Closed in Logs
        Debug.Log("Game Closed");
    }
    public void StartGame()
    {
        //Once Level 2 Button is prssed it loads Level2 Scene
        SceneManager.LoadScene("levelTwo");
    }

}