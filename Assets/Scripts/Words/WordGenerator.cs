using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "accounting", "office", "coworkers", "depression", "misery", "sadness", 
        "slump", "unhappy", "hopeless", "helpless", "weak", "gloomy", "woe", "pen", "paper", "scissors", "stapler", 
        "burnout", "stress", "overwhelmed", "drained", "cubicle", "alone", "isolation", "desk", "chair", "melancholy", "cold" };

    private static int index = 0;

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

    public static string[] orderList = { "wow", "life", "is", "getting", "harder", "and", "each", "day", "it", 
        "is", "getting", "harder", "to", "breathe", "when", "will", "this", "shift", "be", "over", "maybe", 
        "something", "will", "make", "me", "happy", "today", "nothing", "ever", "makes", "me", "happy", "though", 
        "is", "it", "time", "to", "go", "home", "already", "maybe", "i", "will", "not", "feel", "alone", "tonight", 
        "too", "bad", "i", "am", "always", "alone", ".", "NEXT" };


    public static string getOrderedWord()
    {
        string returnWord = orderList[index];
        index++;

        return returnWord;
    }
}
