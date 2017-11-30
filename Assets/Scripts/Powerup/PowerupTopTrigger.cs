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
            Destroy(this.GetComponentInParent<Powerup>().gameObject);
        }
    }
}
