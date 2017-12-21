using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour {

    public GameObject player;
    public int bulletSpeed = 5;
    public float timer = 0;

	void Start ()
    {
		
	}
	

	void Update ()
    {
        if (timer < 2)
        {
            transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);
        }

        else
        {
            gameObject.SetActive(false);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
