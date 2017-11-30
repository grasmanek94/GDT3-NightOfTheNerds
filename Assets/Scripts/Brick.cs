using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<Player>().type == Player.PlayerType.Upgraded)
            {
                this.GetComponents<AudioSource>()[1].Play();
                foreach (BoxCollider2D collider in this.GetComponents<BoxCollider2D>())
                {
                    collider.enabled = false;
                }
                this.GetComponent<SpriteRenderer>().enabled = false;
                Destroy(this.gameObject, 1);
            }
            else if (other.GetComponent<Player>().type == Player.PlayerType.Normal)
            {
                this.GetComponents<AudioSource>()[0].Play();
            }
        }
    }
}
