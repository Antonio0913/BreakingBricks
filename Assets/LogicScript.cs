using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text Scoretext;
    public GameObject GameOverScreen;
    public int PlayerScore;

    public void addScore()
    {
        PlayerScore++;
        Scoretext.text = PlayerScore.ToString();
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
