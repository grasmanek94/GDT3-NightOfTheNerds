using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {


    public int id;
    public List<Sprite> sprites;
    public bool triggered;
    public bool active;
    
	void Awake()
    {
        triggered = false;
    }
	
    // called whenever another collider enters our zone (if layers match)
    public void OnTriggerEnter2D(Collider2D collider)
    {
        // check we haven't been triggered yet!
        if (!triggered)
        {
            if (collider.gameObject.tag == "Player")
            {
                triggered = true;
            }
        }
    }

    void FixedUpdate()
    {
        SetSprite();
    }

    public void SetActive(bool isActive)
    {
        this.active = isActive;
    }

    public void SetSprite()
    {
        if (!triggered)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
        else if (triggered && !active)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        else if (triggered && active)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[2];
        }
    }
}
