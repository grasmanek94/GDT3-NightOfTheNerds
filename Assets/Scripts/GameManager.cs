using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int level;
    public bool jump;
    public bool left;
    public bool right;
	public bool shoot;
    public Button restartButton;
    public Button keyboardButton;
    public Button touchButton;

    private CheckPoint[] checkPoints;
    public Vector3 startCheckPoint;
    public int currentCheckPoint = -1;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        checkPoints = FindObjectsOfType<CheckPoint>();
        DisableCheckPoints();
        if (currentCheckPoint >= 0 || checkPoints.Length > 0)
        {
            Player player = FindObjectOfType<Player>();
            if (GetCurrentCheckPoint() != null)
            {
                player.transform.position = GetCurrentCheckPoint().transform.position + Vector3.back;
            }
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void Restart()
    {
        currentCheckPoint = -1;
        SceneManager.LoadScene(level);
    }

    public void Reload()
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
		
    public void OnCheckPointTriggered(CheckPoint newCheckPoint)
    {
        currentCheckPoint = newCheckPoint.id;
        DisableCheckPoints();
    }
		
    private void DisableCheckPoints()
    {
        foreach (CheckPoint chk in checkPoints)
        {
            if (chk.id == currentCheckPoint)
            {
                chk.active = true;
            }
            else
            {
                chk.active = false;
            }
            chk.SetSprite();
        }
    }

    public CheckPoint GetCurrentCheckPoint()
    {
        CheckPoint chk = null;
        foreach (CheckPoint cp in checkPoints)
        {
            if (cp.id.Equals(currentCheckPoint))
            {
                chk = cp;
                break;
            }
        }
        return chk;
    }
}
