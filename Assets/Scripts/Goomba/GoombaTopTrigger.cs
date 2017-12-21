using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaTopTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<Player>().dead == false)
            {
                other.GetComponent<Player>().Jump();
                this.GetComponentInParent<SpriteRenderer>().flipY = true;
                this.GetComponentInParent<Goomba>().dead = true;
                this.GetComponentInParent<Goomba>().playDeadSound();
                Destroy(this.GetComponentInParent<Goomba>().gameObject, 1);
            }
        }
    }
}
