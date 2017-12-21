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

	//temp---------------------------
	public Vector2 lastCheckPointPos;
	///temp--------------------------

    private CheckPoint[] allCheckPoints;
    private List<int> checkPoints = new List<int>();
    public Vector3 startCheckPoint;
    public int currentCheckPoint = -1;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        allCheckPoints = FindObjectsOfType<CheckPoint>();
        DisableCheckPoints();
        if (currentCheckPoint >= 0)
        {
            Player player = FindObjectOfType<Player>();
            player.transform.position = GetCurrentCheckPoint().transform.position + Vector3.back;
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
        if (AddCheckPoint(newCheckPoint))
        {
            currentCheckPoint = newCheckPoint.id;
            DisableCheckPoints();
        }
    }
		
    private void DisableCheckPoints()
    {
        Debug.Log("allCheckPoints: " + allCheckPoints.Length);
        foreach (CheckPoint chk in allCheckPoints)
        {
            if (checkPoints.Contains(chk.id) && chk.id != currentCheckPoint)
            {
                chk.active = false;
                chk.triggered = true;
            }
            else if (checkPoints.Contains(chk.id) && chk.id == currentCheckPoint)
            {
                chk.active = true;
                chk.triggered = true;
            }
            chk.SetSprite();
        }
    }

    public bool AddCheckPoint(CheckPoint newCheckPoint)
    {
        if (!checkPoints.Contains(newCheckPoint.id))
        {
            checkPoints.Add(newCheckPoint.id);
            return true;
        }
        return false;
    }

    public CheckPoint GetCurrentCheckPoint()
    {
        CheckPoint chk = null;
        foreach (CheckPoint cp in allCheckPoints)
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
