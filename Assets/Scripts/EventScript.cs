using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventScript : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
