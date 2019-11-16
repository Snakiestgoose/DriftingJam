using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    public int score;
    public TextMeshProUGUI scoreText;
    

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score = " + score;
    }

    public void AddWord()
    {

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
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
