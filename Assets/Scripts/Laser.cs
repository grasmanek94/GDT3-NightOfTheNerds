using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			other.GetComponent<Goomba>().dead = true;
			other.GetComponent<SpriteRenderer> ().flipY = true;
			Destroy (other.GetComponent<Goomba>().gameObject, 1);
			Destroy(this.gameObject);
		}
		else if (other.gameObject.tag == "Level")
		{
			Destroy(this.gameObject);
		}
	}
}
