using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text Scoretext;
    public GameObject GameOverScreen;
    public int playerScore;

    public void addScore()
    {
        playerScore++;
        Scoretext.text = playerScore.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
