using UnityEngine;
using System.Collections;

public class PlayerMoveController : MonoBehaviour {

	// PUBLIC
	public SimpleTouchController leftController;
	public float speedMovements = 5;

	// PRIVATE
	private Rigidbody _rigidbody;
    private GameObject player;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
        player = gameObject.GetComponent<ControlsManager>().playerObject;
	}

	void FixedUpdate()
	{
		// move
		//_rigidbody.MovePosition(transform.position + (transform.forward * leftController.GetTouchPosition.y * Time.deltaTime * speedMovements) +
		//	(transform.right * leftController.GetTouchPosition.x * Time.deltaTime * speedMovements) );

        if (leftController.GetTouchPosition.x > 0)
        {
            player.GetComponent<Player>().moveDirection = Player.Direction.Right;
            player.GetComponent<Player>().isMoving = true;
        }
        else if (leftController.GetTouchPosition.x < 0)
        {
            player.GetComponent<Player>().moveDirection = Player.Direction.Left;
            player.GetComponent<Player>().isMoving = true;
        }
        else if (leftController.GetTouchPosition.x == 0)
        {
            player.GetComponent<Player>().isMoving = false;
        }
        player.transform.Translate(new Vector2(player.GetComponent<Player>().walkSpeed * leftController.GetTouchPosition.x / 10, 0));
    }
}
