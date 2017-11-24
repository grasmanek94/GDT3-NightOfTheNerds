using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupType type;
    public float walkSpeed;
    public Direction moveDirection;

    public enum PowerupType { Mushroom }
    public enum Direction { Left, Right };

    void FixedUpdate()
    {
        if (moveDirection == Direction.Right)
        {
            this.transform.Translate(new Vector2(walkSpeed / 10, 0));
        }
        else if (moveDirection == Direction.Left)
        {
            this.transform.Translate(new Vector2(-walkSpeed / 10, 0));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (type == PowerupType.Mushroom)
            {
                other.GetComponent<Player>().type = Player.PlayerType.Mushroom;
            }
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "Level" || other.gameObject.tag == "Enemy" || other.gameObject.tag == "Powerup")
        {
            if (this.GetComponentInParent<Powerup>().moveDirection == Powerup.Direction.Left)
            {
                this.GetComponentInParent<Powerup>().moveDirection = Powerup.Direction.Right;
            }
            else if (this.GetComponentInParent<Powerup>().moveDirection == Powerup.Direction.Right)
            {
                this.GetComponentInParent<Powerup>().moveDirection = Powerup.Direction.Left;
            }
        }
    }
}
