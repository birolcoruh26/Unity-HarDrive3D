using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public TextMeshProUGUI highScoreText;
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitTheGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    private void Start()
    {
        
        highScoreText.text = "HighScore: " + PlayerPrefs.GetFloat("Highscore");
    }
}
