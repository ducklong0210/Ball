using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController gameController;
    public void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            gameController.IncrementScore();
            Destroy(gameObject);
            Debug.Log("Qua bong da va cham voi gia do");
        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("DeathZone"))
        {
            gameController.setIsGameOver(true);
            Destroy(gameObject);
            Debug.Log("Qua bong da va cham voi deathzone, Gameover");
        }
    }
}
