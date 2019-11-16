using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    public GameController gameController;

    public void Start()
    {
        gameController = gameController.GetComponent<GameController>();
        Debug.Log(gameController.gameOver);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        gameController.gameOver = true;
        Debug.Log(gameController.gameOver);
        
    }
    
}
