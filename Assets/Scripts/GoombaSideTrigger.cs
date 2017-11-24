using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaSideTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<Player>().type == Player.PlayerType.Normal)
            {
                other.GetComponent<Player>().dead = true;
            }
            else if (other.GetComponent<Player>().type == Player.PlayerType.Mushroom)
            {
                other.GetComponent<Player>().type = Player.PlayerType.Normal;
            }
        }
        else if (other.gameObject.tag == "Level" || other.gameObject.tag == "Enemy" || other.gameObject.tag == "Powerup")
        {
            if (this.GetComponentInParent<Goomba>().moveDirection == Goomba.Direction.Left)
            {
                this.GetComponentInParent<Goomba>().moveDirection = Goomba.Direction.Right;
            }
            else if (this.GetComponentInParent<Goomba>().moveDirection == Goomba.Direction.Right)
            {
                this.GetComponentInParent<Goomba>().moveDirection = Goomba.Direction.Left;
            }
        }
    }
}
