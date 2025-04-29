using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    // thời gian tạo ra quả bóng tiếp theo
    public float spawnTime;

    bool statusGame = false;

    float m_spawnTime;

    int m_score;

    bool m_isGameOver;
    UIManager uIManager;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        uIManager.SetScoreText("Score: " + m_score);
        uIManager.ShowStart(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (statusGame != true)
            return;

        m_spawnTime -= Time.deltaTime;

        if (m_isGameOver == true)
        {
            m_spawnTime = 0;
            uIManager.ShowGameOver(true);

            return;
        }
        if (statusGame == true)
        {
            if (m_spawnTime <= 0)
            {
                SqawnBall();
                m_spawnTime = spawnTime;
            }
        }

        if (m_score == 100)
        {
            m_spawnTime = 0;
            statusGame = false;
            uIManager.ShowGameWin(true);
            return;
        }


    }

    public void SqawnBall()
    {

        if (statusGame == true || m_isGameOver == true)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-6, 6), 6);

            if (ball)
            { 
                Instantiate(ball, spawnPos, Quaternion.identity);
            }
        }

    }


    public void setScore(int score)
    {
        m_score = score;
    }
    public int getScore()
    {
        return m_score;
    }
    public void IncrementScore()
    {
        m_score++;
        uIManager.SetScoreText("Score: " + m_score);

    }
    public void setIsGameOver(bool isGameOver)
    {
        m_isGameOver = isGameOver;
    }
    public bool isGameOver()
    {
        return m_isGameOver;
    }

    public void Replay()
    {
        m_score = 0;
        m_isGameOver = false;
        uIManager.SetScoreText("Score: " + m_score);
        statusGame = true;
        uIManager.ShowGameOver(false);
    }

    public void ButtonStart()
    {
        m_spawnTime = 0;
        statusGame = true;

        uIManager.ShowStart(false);
    }
    public void WinGame()
    {
        m_score = 0;
        m_isGameOver = false;
        uIManager.SetScoreText("Score: " + m_score);
        statusGame = true;
        uIManager.ShowGameWin(false);
    }


}
