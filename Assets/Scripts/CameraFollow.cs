using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float smoothnessXAxis;
    public float smoothnessYAxis;

    public GameObject player;

    public Vector3 minimalBounds;
    public Vector3 maximalBounds;

    private Vector2 velocity;

    private void FixedUpdate()
    {

        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothnessXAxis);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothnessYAxis);

        transform.position = new Vector3(posX, posY, transform.position.z);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minimalBounds.x, maximalBounds.x),
            Mathf.Clamp(transform.position.y, minimalBounds.y, maximalBounds.y),
            Mathf.Clamp(transform.position.z, minimalBounds.z, maximalBounds.z));

    }
}
