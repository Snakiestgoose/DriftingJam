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

    private int typeIndex = 0;

    public string spells;
    
    public void SetSpells()
    {
        spells = "ice";
    }

    // Update is called once per frame
    void Update()
    {
        if (player.playerMode == 1)
        {
            //Code for TypeMode
            foreach (char letter in Input.inputString)
            {
                //TypeLetter(letter);
                if (letter.CompareTo(spells[typeIndex]) == 0)
                {
                    if (typeIndex > spells.Length)
                    {
                        typeIndex = 0;
                        Debug.Log("Boom");
                    }
                }
                

            }



        }
    }

    /*
    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            //check if letter was next then remove letter
            if (activeWord.GetNextLetter() == letter)
            {
                //activeWord.TypeLetter();
                typeIndex++;
            }
        }
        else
        {
            foreach (Word word in spells)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    Debug.Log(activeWord);
                    hasActiveWord = true;
                    //word.TypeLetter();
                    typeIndex++;
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.word.Length < typeIndex)
        {
            hasActiveWord = false;
            Debug.Log("Boom");
            //shoot blaster

            
        }

    }

    public char GetNextLetter()
    {
        return activeWord.word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
    }

    */


}
