using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSideTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (this.GetComponentInParent<Powerup>().type == Powerup.PowerupType.Upgraded)
            {
                other.GetComponent<Player>().Powerup(Player.PlayerType.Upgraded);
            }
            Destroy(this.GetComponentInParent<Powerup>().gameObject);
        }
        else if (other.gameObject.tag == "Level" || other.gameObject.tag == "Enemy" || other.gameObject.tag == "Powerup")
        {
            Debug.Log("hit");
            if (this.GetComponentInParent<Powerup>().moveDirection == Powerup.Direction.Left)
            {
                Debug.Log("right");
                this.GetComponentInParent<Powerup>().moveDirection = Powerup.Direction.Right;
            }
            else if (this.GetComponentInParent<Powerup>().moveDirection == Powerup.Direction.Right)
            {
                Debug.Log("left");
                this.GetComponentInParent<Powerup>().moveDirection = Powerup.Direction.Left;
            }
        }
    }
}
