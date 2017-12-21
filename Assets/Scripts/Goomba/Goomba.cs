using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private float endPosX;
    private float endPosY;
    public float range;
    public Mode mode;
    public Direction direction;
    public Direction currentDirection;
    public MovementType movementType;

    public enum Mode { Horizontal, Vertical }
    public enum Direction { Forward, Backward }
    public enum MovementType { Walking, Flying }


    public float speed;
    public bool dead;


    private void Start()
    {
        startPosX = this.transform.position.x;
        startPosY = this.transform.position.y;
        if (this.direction == Direction.Forward)
        {
            if (mode == Mode.Horizontal)
            {
                endPosX = this.transform.position.x + range;
                endPosY = this.transform.position.y;
            }
            else if (mode == Mode.Vertical)
            {
                endPosY = this.transform.position.y + range;
                endPosX = this.transform.position.x;
            }
        }
        else if (this.direction == Direction.Backward)
        {
            if (mode == Mode.Horizontal)
            {
                endPosX = this.transform.position.x - range;
                endPosY = this.transform.position.y;
            }
            else if (mode == Mode.Vertical)
            {
                endPosY = this.transform.position.y - range;
                endPosX = this.transform.position.x;
            }
        }
    }

    void FixedUpdate () {
        if (dead == false)
        {
            if (movementType == MovementType.Walking)
            {
                if (currentDirection == Direction.Forward)
                {
                    this.GetComponent<SpriteRenderer>().flipX = false;
                    this.transform.Translate(new Vector2(speed / 10, 0));
                }
                else if (currentDirection == Direction.Backward)
                {
                    this.GetComponent<SpriteRenderer>().flipX = true;
                    this.transform.Translate(new Vector2(-speed / 10, 0));
                }
            }
            else if (movementType == MovementType.Flying)
            {
                if (range != 0)
                {
                    if (this.direction == Direction.Forward)
                    {
                        if (this.transform.position.x > endPosX)
                        {
                            currentDirection = Direction.Backward;
                        }
                        else if (this.transform.position.x < startPosX)
                        {
                            currentDirection = Direction.Forward;
                        }
                        if (this.transform.position.y > endPosY)
                        {
                            currentDirection = Direction.Backward;
                        }
                        else if (this.transform.position.y < startPosY)
                        {
                            currentDirection = Direction.Forward;
                        }
                    }
                    else if (this.direction == Direction.Backward)
                    {
                        if (this.transform.position.x < endPosX)
                        {
                            currentDirection = Direction.Forward;
                        }
                        else if (this.transform.position.x > startPosX)
                        {
                            currentDirection = Direction.Backward;
                        }
                        if (this.transform.position.y < endPosY)
                        {
                            currentDirection = Direction.Forward;
                        }
                        else if (this.transform.position.y > startPosY)
                        {
                            currentDirection = Direction.Backward;
                        }
                    }


                    if (currentDirection == Direction.Forward && mode == Mode.Horizontal)
                    {
                        this.GetComponent<SpriteRenderer>().flipX = false;
                        this.transform.Translate(new Vector2(speed / 10, 0));
                    }
                    else if (currentDirection == Direction.Backward && mode == Mode.Horizontal)
                    {
                        this.GetComponent<SpriteRenderer>().flipX = true;
                        this.transform.Translate(new Vector2(-speed / 10, 0));
                    }
                    else if (currentDirection == Direction.Forward && mode == Mode.Vertical)
                    {
                        this.transform.Translate(new Vector2(0, speed / 10));
                    }
                    else if (currentDirection == Direction.Backward && mode == Mode.Vertical)
                    {
                        this.transform.Translate(new Vector2(0, -speed / 10));
                    }
                }
            }
        }
        else if (dead == true)
        {
            this.GetComponent<Animator>().speed = 0;
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
            this.GetComponent<CapsuleCollider2D>().enabled = false;
            foreach (BoxCollider2D collider in this.GetComponentsInChildren<BoxCollider2D>())
            {
                collider.enabled = false;
            }
            this.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}