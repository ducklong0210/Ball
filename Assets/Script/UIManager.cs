using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameWinPanel;

    public GameObject gameOverPanel;
    public GameObject gameStartPanel;

    public void SetScoreText(string txt)
    {
        if (scoreText)
        {
            scoreText.text = txt;
        }
    }

    public void ShowGameOver(bool isShow)
    {
        if (gameOverPanel)
        {
            gameOverPanel.SetActive(isShow);
        }
    }
    public void ShowStart(bool isShow)
    {
        if (gameStartPanel)
        {
            gameStartPanel.SetActive(isShow);
        }
    }
    public void ShowGameWin(bool isShow)
    {
        if (gameWinPanel)
        {
            gameWinPanel.SetActive(isShow);
        }
    }
}
