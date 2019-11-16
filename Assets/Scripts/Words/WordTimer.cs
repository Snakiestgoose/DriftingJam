using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;
    public GameController gameController;

    public float wordDelay = 1.5f;
    private float nextWordTime = 0f;

    public void Start()
    {
        gameController = gameController.GetComponent<GameController>();
    }

    private void Update()
    {
        if(Time.time >= nextWordTime && gameController.gameOver == false)
        {
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= .99f;
        }
    }
}
