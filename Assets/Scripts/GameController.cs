using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int gameMode;
    public bool gameOver;
    public GameObject controller;
    public int score;
    public TextMeshProUGUI scoreText;

    /*
     * GAMEMODES
     * 
     * 0 - Main Menu
     * 1 - Office Arcade
     * 2 - Dreams Arcade
     * 3 - Office 
     * 4 - Dreams
     * 
     */
     
       



    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        scoreText.text = "Score = " + score;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && gameMode != 2)
        {
            Destroy(controller);
        }
        
    }

    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score = " + score;
    }
}
