using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlsManager : MonoBehaviour
{
    public GameObject playerObject;
    private Player player;
	void Start()
    {
        Input.multiTouchEnabled = true;
        player = playerObject.GetComponent<Player>();
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
        if (player.isGrounded == true && player.jumped == false)
        {
            player.Jump();
            player.jumped = true;
        }
    }
}
