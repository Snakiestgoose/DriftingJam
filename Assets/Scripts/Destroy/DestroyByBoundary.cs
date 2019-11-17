using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DestroyByBoundary : MonoBehaviour
{
    public GameController gameController;
    public TextMeshProUGUI gameOverText;
    public Button menu;

    public void Start()
    {
        gameController = gameController.GetComponent<GameController>();
        Debug.Log(gameController.gameOver);
        gameOverText.text = "";
        menu.gameObject.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(gameController.gameMode == 1)
        {
            gameOverText.text = "GAME OVER!";
            gameController.gameOver = true;
            menu.gameObject.SetActive(true);
        }
        
        if(gameController.gameMode == 2)
        {
            Destroy(other.gameObject);
        }
    }
    
}
