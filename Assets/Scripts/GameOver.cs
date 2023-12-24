using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void StartGame()
    {
        //Once button is clicked takes you to MainMenu
        SceneManager.LoadScene("MainMenu");
    }

}
