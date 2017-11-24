using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaHeadTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().jump();
            this.GetComponentInParent<SpriteRenderer>().sprite = this.GetComponentInParent<Goomba>().spriteDead;
            this.GetComponentInParent<Goomba>().dead = true;
            Destroy(this.GetComponentInParent<Goomba>().gameObject, 1);
        }
    }
}