using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite spriteStandLeft;
    public Sprite spriteStandRight;
    public Sprite spriteWalkLeft;
    public Sprite spriteWalkRight;
    public Sprite spriteJumpLeft;
    public Sprite spriteJumpRight;
    public Sprite spriteDead;
    private bool isGrounded = false;
    public LayerMask playerMask;
    public float walkSpeed;
    public float jumpHeight;
    public bool dead;
    public Direction moveDirection;
    public PlayerType type;

    public enum PlayerType { Normal, Mushroom }
    public enum Direction { Left, Right }

    void FixedUpdate()
    {
        isGrounded = Physics2D.Linecast(this.transform.position, new Vector2(this.transform.position.x, this.transform.position.y - 0.35f), playerMask);

        if (this.dead == false)
        {
            if (Input.GetKey("left"))
            {
                this.moveDirection = Direction.Left;
                this.transform.Translate(new Vector2(-walkSpeed / 10, 0));
            }
            if (Input.GetKey("right"))
            {
                this.moveDirection = Direction.Right;
                this.transform.Translate(new Vector2(walkSpeed / 10, 0));
            }
            if (Input.GetKey("up") && isGrounded == true)
            {
                jump();
            }
        }
        else if (dead == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            this.GetComponent<CapsuleCollider2D>().enabled = false;
        }
        changeSprite();
    }

    public void jump()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
    }

    void changeSprite()
    {
        if (type == PlayerType.Normal)
        {
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else if (type == PlayerType.Mushroom)
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (dead == false)
        {
            if (moveDirection == Direction.Left)
            {
                if (Input.GetKey("left") == true)
                {
                    if (this.isGrounded == true)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteWalkLeft;
                    }
                    else if (this.isGrounded == false)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteJumpLeft;
                    }

                }
                else if (Input.GetKey("left") == false)
                {
                    if (this.isGrounded == true)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteStandLeft;
                    }
                    else if (this.isGrounded == false)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteJumpLeft;
                    }
                }
            }
            else if (moveDirection == Direction.Right)
            {
                if (Input.GetKey("right") == true)
                {
                    if (this.isGrounded == true)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteWalkRight;
                    }
                    else if (this.isGrounded == false)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteJumpRight;
                    }

                }
                else if (Input.GetKey("right") == false)
                {
                    if (this.isGrounded == true)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteStandRight;
                    }
                    else if (this.isGrounded == false)
                    {
                        this.GetComponent<SpriteRenderer>().sprite = spriteJumpRight;
                    }
                }
            }
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = spriteDead;
        }

    }
}
