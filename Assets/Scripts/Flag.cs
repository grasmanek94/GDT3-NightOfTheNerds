using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().level++;
            gameManager.GetComponent<GameManager>().Restart();
        }
    }
}
