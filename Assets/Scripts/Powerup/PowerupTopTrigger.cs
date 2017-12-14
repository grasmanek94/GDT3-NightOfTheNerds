using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupTopTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			if (this.GetComponentInParent<Powerup>().type == Powerup.PowerupType.Upgraded)
			{
				other.GetComponent<Player>().Powerup(Player.PlayerType.Upgraded);
			}
			else if (this.GetComponentInParent<Powerup>().type == Powerup.PowerupType.Shooter)
			{
				other.GetComponent<Player>().Powerup(Player.PlayerType.Shooter);
			}
			Destroy(this.GetComponentInParent<Powerup>().gameObject);
        }
    }
}
