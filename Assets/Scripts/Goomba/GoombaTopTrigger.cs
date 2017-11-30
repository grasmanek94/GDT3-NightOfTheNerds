using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaTopTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().Jump();
            this.GetComponentInParent<AudioSource>().Play();
			this.GetComponentInParent<SpriteRenderer>().flipY = true;
            this.GetComponentInParent<Goomba>().dead = true;
            Destroy(this.GetComponentInParent<Goomba>().gameObject, 1);
        }
    }
}
