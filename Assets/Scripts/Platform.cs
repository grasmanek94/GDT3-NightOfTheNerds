using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    private float startPosX;
    private float startPosY;
    private float endPosX;
    private float endPosY;
    public float range;
    public float speed;
    public Mode mode;
    private Direction direction;

    public enum Mode { Horizontal, Vertical }
    public enum Direction { Forward, Backward }

	void Start () {
        startPosX = this.transform.position.x;
        startPosY = this.transform.position.y;
        if (mode == Mode.Horizontal)
        {
            endPosX = this.transform.position.x + range;
            endPosY = this.transform.position.y;
        }
        else if (mode == Mode.Vertical)
        {
            endPosY = this.transform.position.y + range;
            endPosX = this.transform.position.x;
        }
	}
	
	void FixedUpdate () {
        if (this.transform.position.x > endPosX)
        {
            direction = Direction.Backward;
        }
        else if (this.transform.position.x < startPosX)
        {
            direction = Direction.Forward;
        }
        if (this.transform.position.y > endPosY)
        {
            direction = Direction.Backward;
        }
        else if (this.transform.position.y < startPosY)
        {
            direction = Direction.Forward;
        }


        if (direction == Direction.Forward && mode == Mode.Horizontal)
        {
            this.transform.position += this.transform.right * speed * Time.deltaTime;
        }
        else if (direction == Direction.Backward && mode == Mode.Horizontal)
        {
            this.transform.position += this.transform.right * -speed * Time.deltaTime;
        }
        else if (direction == Direction.Forward && mode == Mode.Vertical)
        {
            this.transform.position += this.transform.up * speed * Time.deltaTime;
        }
        else if (direction == Direction.Backward && mode == Mode.Vertical)
        {
            this.transform.position += this.transform.up * -speed * Time.deltaTime;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy" || other.gameObject.tag == "Powerup")
        {
            other.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy" || other.gameObject.tag == "Powerup")
        {
            other.transform.parent = null;
        }
    }
}
