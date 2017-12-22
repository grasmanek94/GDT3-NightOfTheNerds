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
 
    }

    public void OnSubmit(string action)
    {     
        if (action == "jump")
        {
            jump();
        }

        else if(action == "shoot")
        {
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
