using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class speakingScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Image image;
    private static int textIndex;

    // Start is called before the first frame update
    void Start()
    {
        textIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SetText();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            textIndex++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
    }

    private void SetText()
    {
        if(textIndex == 0)
        {
            text.text = "'I see you finally made it!'";
        }
        else if (textIndex == 1)
        {
            text.text = "'...'";
        }
        else if (textIndex == 2)
        {
            text.text = "'Not much of a talker I take it?'";
        }
        else if (textIndex == 3)
        {
            text.text = "'...'";
        }
        else if (textIndex == 4)
        {
            text.text = "'Well alrighty. Nevertheless, welcome to your dreamland - a place you can escape your normal, boring and depressing life.'";
        }
        else if (textIndex == 5)
        {
            text.text = "'...'";
        }
        else if (textIndex == 6)
        {
            text.text = "'I'm a wizard who controls the element of ice - and now that you have finally made it here you are also a wizard!'";
        }
        else if (textIndex == 7)
        {
            text.text = "'Wait, how does tha...'";
        }
        else if (textIndex == 8)
        {
            text.text = "'Silly you, don't ask questions. Here take the elemental power of ice. '";
        }
        else if (textIndex == 9)
        {
            text.text = "'To use it, just press the SPACE BAR to enter into typing mode, and start typing the word ICE to shoot out ice beams.'";
        }
        else if (textIndex == 10)
        {
            text.text = "'So, I'm a wiz....'";
        }
        else if (textIndex == 11)
        {
            text.text = "'I must be off now, have fun and don't die!'";
        }


    }
}
