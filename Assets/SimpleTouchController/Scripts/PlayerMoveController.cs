using UnityEngine;
using System.Collections;

public class PlayerMoveController : MonoBehaviour {

	// PUBLIC
	public SimpleTouchController leftController;
	public float speedMovements = 5;

	// PRIVATE
	private Rigidbody _rigidbody;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		// move
		_rigidbody.MovePosition(transform.position + (transform.forward * leftController.GetTouchPosition.y * Time.deltaTime * speedMovements) +
			(transform.right * leftController.GetTouchPosition.x * Time.deltaTime * speedMovements) );
	}
}
