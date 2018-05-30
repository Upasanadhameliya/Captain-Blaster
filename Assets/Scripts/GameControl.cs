using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public Text scoreText, gameOverText;
    public Image gameOverImage;
    int playerScore = 0;

    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void PlayerDied()
    {
        gameOverImage.enabled = true;
        gameOverText.enabled = true;
        Time.timeScale = 0;
    }
}
