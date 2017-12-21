using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaTopTrigger : MonoBehaviour {

    [SerializeField]
    AudioSource[] audio_sources;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<Player>().dead == false)
            {
                other.GetComponent<Player>().Jump();
                int index = Random.Range(1, audio_sources.Length);
                AudioSource source = audio_sources[index];
                AudioSource zero = audio_sources[0];
                audio_sources[0] = source;
                audio_sources[index] = zero;
                source.Play();
                this.GetComponentInParent<SpriteRenderer>().flipY = true;
                this.GetComponentInParent<Goomba>().dead = true;
                Destroy(this.GetComponentInParent<Goomba>().gameObject, 1);
            }
        }
    }
}
