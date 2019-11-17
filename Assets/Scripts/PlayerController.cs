﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd2d;
    public float speed;
    private Vector3 change;
    public int playerMode;

    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;

    Animator anim;

    public GameObject magicBolt;
    public TypeMode typeMode;
    

    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        playerMode = 0;

        text1.text = "";
        text2.text = "";
        text3.text = "";
        text4.text = "";

        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMode == 0)
        {
            change = Vector3.zero;
            change.x = Input.GetAxisRaw("Horizontal");
            change.y = Input.GetAxisRaw("Vertical");
            UpdateAnimationAndMove();

            text1.text = "";
            text2.text = "";
            text3.text = "";
            text4.text = "";
        }
        if(playerMode == 1)
        {
            anim.SetInteger("State", 5);
            text1.text = "ice";
            text2.text = "";
            text3.text = "";
            text4.text = "";

            typeMode.SetSpells();

        }
        
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (playerMode == 0)
            {
                playerMode = 1;
                




            }
            else if (playerMode == 1)
            {
                playerMode = 0;
            }
                

        }


    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            rd2d.MovePosition(transform.position + (change * speed * Time.deltaTime));
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            anim.SetInteger("State", 2);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            anim.SetInteger("State", 4);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            anim.SetInteger("State", 1);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetInteger("State", 3);
        }
        if (change == Vector3.zero)
        {
            anim.SetInteger("State", 0);
        }
        

    }
}
