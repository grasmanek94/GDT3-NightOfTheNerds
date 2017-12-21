using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int level;
    public bool jump;
    public bool left;
    public bool right;
	public bool shoot;
    public Button restartButton;
    public Button keyboardButton;
    public Button touchButton;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void Restart()
    {
        SceneManager.LoadScene(level);
    }

    public void Keyboard()
    {
        keyboardButton.gameObject.SetActive(false);
        touchButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
        level++;
        Restart();
    }

    public void Touch()
    {
        keyboardButton.gameObject.SetActive(false);
        touchButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
        level++;
        Restart();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            level++;
            Restart();
        }
    }

    public void JumpDown()
    {
        jump = true;
    }

    public void JumpUp()
    {
        jump = false;
    }

    public void LeftDown()
    {
        left = true;
    }

    public void LeftUp()
    {
        left = false;
    }

    public void RightDown()
    {
        right = true;
    }

    public void RightUp()
    {
        right = false;
    }

	public void ShootDown()
	{
		shoot = true;
	}

	public void ShootUp()
	{
		shoot = false;
	}
}
