using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeMode : MonoBehaviour
{
    public PlayerController player;
    public int magicSpells;

    private bool hasActiveWord;
    private Word activeWord;

    public List<Word> spells = new List<Word>();

    public void SetSpells()
    {
        Word word = new Word(player.text1.text);
        spells.Add(word);
        word = new Word(player.text2.text);
        spells.Add(word);
        word = new Word(player.text3.text);
        spells.Add(word);
        word = new Word(player.text4.text);
        spells.Add(word);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.playerMode == 1)
        {
            //Code for TypeMode
            foreach (char letter in Input.inputString)
            {
                TypeLetter(letter);
            }



        }
    }


    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            //check if letter was next then remove letter
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in spells)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            Debug.Log("Boom");
            //shoot blaster

            
        }

    }






}
