using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public Sprite spriteLeft;
    public Sprite spriteRight;
    public Sprite spriteDead;
    public float walkSpeed;
    public Direction moveDirection;
    public bool dead;

    public enum Direction { Left, Right};
	
	void FixedUpdate () {
        if (dead == false)
        {
            if (moveDirection == Direction.Right)
            {
                this.GetComponent<SpriteRenderer>().sprite = spriteRight;
                this.transform.Translate(new Vector2(walkSpeed / 10, 0));
            }
            else if (moveDirection == Direction.Left)
            {
                this.GetComponent<SpriteRenderer>().sprite = spriteLeft;
                this.transform.Translate(new Vector2(-walkSpeed / 10, 0));
            }
        }
        else if (dead == true)
        {
            this.GetComponent<CapsuleCollider2D>().enabled = false;
            foreach (BoxCollider2D collider in this.GetComponentsInChildren<BoxCollider2D>())
            {
                collider.enabled = false;
            }
            this.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}