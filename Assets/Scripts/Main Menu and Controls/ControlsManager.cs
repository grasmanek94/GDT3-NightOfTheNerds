using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlsManager : MonoBehaviour
{
    private Player player;
	void Start()
    {
        Input.multiTouchEnabled = true;
        player = GetComponentInChildren<Player>();
    }
	
	void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            jump();
        }
    }

    public void OnSubmit(string action)
    {     
        Debug.Log("submit");
        if (action == "jump")
        {
            jump();
        }

        else if(action == "shoot")
        {
            Debug.Log(player.type);
            if (player.type == Player.PlayerType.Shooter && player.fired == false)
            {
                player.Shoot();
                player.fired = true;
            }
        }
    }

    public void jump()
    {
        GetComponentsInChildren<AudioSource>()[3].Play();
        GetComponentInChildren<Rigidbody2D>().velocity = Vector2.zero;
        GetComponentInChildren<Rigidbody2D>().AddForce(new Vector2(0, player.jumpHeight), ForceMode2D.Impulse);
    }
}
