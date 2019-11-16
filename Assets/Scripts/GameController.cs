using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int gameMode;
    public bool gameOver;
    public GameObject controller;


    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Destroy(controller);
        }
        
    }
}
