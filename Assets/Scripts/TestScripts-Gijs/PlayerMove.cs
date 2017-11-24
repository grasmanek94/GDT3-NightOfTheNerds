using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float playerSpeed;
    public float jumpPower;
    public float friction;

    private bool goingRight; 
    private bool goingLeft;
    private bool playerIsGrounded;

    private Rigidbody2D rb2d;
    private Animator anim;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            playerIsGrounded = true;
            anim.SetBool("grounded", true);
        }

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            playerIsGrounded = true;
            anim.SetBool("grounded", true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            playerIsGrounded = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && playerIsGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
            anim.SetBool("grounded", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) && !goingLeft)
        {
            rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
            goingRight = true;
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            goingRight = false;
        }


        if (Input.GetKey(KeyCode.LeftArrow) && !goingRight)
        {
            rb2d.velocity = new Vector2(-playerSpeed, rb2d.velocity.y);
            goingLeft = true;
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            goingLeft = false;
        }

        anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (gameObject.transform.position.y < -3)
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }

    void FixedUpdate()
    {
        //Fixes the absence of friction on objects
        Vector3 frictionFix = rb2d.velocity;
        frictionFix.y = rb2d.velocity.y;
        frictionFix.z = 0.0f;
        frictionFix.x *= friction;
        rb2d.velocity = frictionFix;
    }
}
