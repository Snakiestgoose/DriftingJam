using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "accounting", "office", "accruals", "advertise", "ruby", "dog", "derp", "yellow", "butt", "hole"    };
    private static int index = 0;

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

    public static string[] orderList = { "I", "work", "in", "an", "office", ".", "GameOver" };

    public static string getOrderedWord()
    {
        string returnWord = orderList[index];
        index++;

        return returnWord;
    }
}
