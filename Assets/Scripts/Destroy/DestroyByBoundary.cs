using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyByBoundary : MonoBehaviour
{
    public GameController gameController;
    public TextMeshProUGUI gameOverText;

    public void Start()
    {
        gameController = gameController.GetComponent<GameController>();
        Debug.Log(gameController.gameOver);
        gameOverText.text = "";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameOverText.text = "GAME OVER!";
        gameController.gameOver = true;
    }
    
}
