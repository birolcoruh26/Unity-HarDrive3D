using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        coinsText.text = "Score:" + numberOfCoins;
        if(PlayerPrefs.GetFloat("Highscore") < numberOfCoins)
        {
            PlayerPrefs.SetFloat("Highscore", numberOfCoins);
        }
    }

}
