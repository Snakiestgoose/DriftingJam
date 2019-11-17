using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameController gameController;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' Script");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        gameController.UpdateScore();
        if(other.tag != "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        

    }

}
