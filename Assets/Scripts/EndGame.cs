using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision .transform .name == "Obstacles")
        {
            Debug.Log("End Game");
            SceneManager.LoadScene("Survived");
        }
    }

}