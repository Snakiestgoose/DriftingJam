using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public int scoreValue;
    public GameController gameController;
    
    private void Start()
    {
        gameController = gameController.GetComponent<GameController>();
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
