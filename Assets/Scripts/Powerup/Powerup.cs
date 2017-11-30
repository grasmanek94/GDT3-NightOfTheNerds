using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupType type;
    public float walkSpeed;
    public Direction moveDirection;

    public enum PowerupType { Upgraded }
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
}
