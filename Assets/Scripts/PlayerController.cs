using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd2d;
    public float speed;
    private Vector3 change;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();


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
