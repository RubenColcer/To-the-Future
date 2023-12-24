using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
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
        //Once Level 1 Button is prssed it loads Level1 Scene
        SceneManager.LoadScene("levelOne");
    }

}