using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    public int score;
    public TextMeshProUGUI scoreText;

    public GameController gameController;
    public WordSpawner wordSpawner;
    public Button nextButton;

    private bool hasActiveWord;
    private Word activeWord;

    private void Start()
    {
        gameController = gameController.GetComponent<GameController>();
        nextButton = nextButton.GetComponent<Button>();
        score = 0;
        scoreText.text = "Score = " + score;
    }

    public void AddWord()
    {

        Word word;
        if(gameController.gameMode == 3)
        {
            word = new Word(WordGenerator.getOrderedWord(), wordSpawner.SpawnWord()); 
        }
        else
        {
            word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        }

        if(word.word == "NEXT")
        {
            gameController.gameOver = true;
            nextButton.gameObject.SetActive(true);
        }
        else
        {
            words.Add(word);
        }

        
    }

    public void TypeLetter (char letter)
    {
        if(hasActiveWord)
        {
            //check if letter was next then remove letter
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            UpdateScore();
        }

    }

    private void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score = " + score;
    }
}
