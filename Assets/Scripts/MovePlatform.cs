using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

	public bool horizontal;
	public float speed;
	public float startPositionX, startPositionY;
    private float endPositionX, endPositionY;
    public float moveRange;
	private Player player;
    private readonly float width = 1.28f;
    private readonly float height = 0.16f;
    private bool moveUp;
    private bool moveRight;

	// Use this for initialization
	void Start () {
        startPositionX = transform.position.x;
        startPositionY = transform.position.y;
        endPositionX = transform.position.x + moveRange;
        endPositionY = transform.position.y + moveRange;
	}
	
	// Update is called once per frame
	void Update () {
        turnAround();
		if (horizontal) {
			moveHorizontal();
		} else {
			moveVertical();
		}
	}
	
	private void moveVertical() {
        if (moveUp) transform.position += transform.up * speed * Time.deltaTime;
        if (!moveUp) transform.position -= transform.up * speed * Time.deltaTime;
	}
	
	private void moveHorizontal() {
        if (moveRight) transform.position += transform.right * speed * Time.deltaTime;
        if (!moveRight) transform.position -= transform.right * speed * Time.deltaTime;
	}

    private void turnAround() {
        if (horizontal)
        {
            if (transform.position.x >= endPositionX)
            {
                moveRight = false;
            }
            if (transform.position.x <= startPositionX)
            {
                moveRight = true;
            }
        } 
        else
        {
            if (transform.position.y >= endPositionY)
            {
                moveUp = false;
            }
            if (transform.position.y <= startPositionY)
            {
                moveUp = true;
            }
        }
    }
}
