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
    public Button jumpButton;
    public Button leftButton;
    public Button rightButton;
	public Button shootButton;
    public Button restartButton;
    public Button keyboardButton;
    public Button touchButton;

    // Checkpoints
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
        Debug.Log("OnSceneLoaded");
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
        Debug.Log("OnEnable");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
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
        jumpButton.gameObject.SetActive(true);
        leftButton.gameObject.SetActive(true);
        rightButton.gameObject.SetActive(true);
		shootButton.gameObject.SetActive(true);
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

    /// <summary>
    /// This method sets the current checkpoint to the new checkpoint.
    /// Once the currentcheckpoint has changed, all previous triggered checkpoints should be disabled.
    /// </summary>
    /// <param name="newCheckPoint"></param>
    public void OnCheckPointTriggered(CheckPoint newCheckPoint)
    {
        if (AddCheckPoint(newCheckPoint))
        {
            currentCheckPoint = newCheckPoint.id;
            DisableCheckPoints();
        }
    }

    /// <summary>
    /// This method disables all the previously triggered checkpoints, which do not match the given checkpointId. 
    /// The sprite for each checkpoint should be changed accordingly.
    /// </summary>
    private void DisableCheckPoints()
    {
        Debug.Log("allCheckPoints: " + allCheckPoints.Length);
        foreach (CheckPoint chk in allCheckPoints)
        {
            if (checkPoints.Contains(chk.id) && chk.id != currentCheckPoint)
            {
                chk.active = false;
                chk.triggered = true;
                Debug.Log("Not current checkpoint.");
            }
            else if (checkPoints.Contains(chk.id) && chk.id == currentCheckPoint)
            {
                chk.active = true;
                chk.triggered = true;
                Debug.Log("Current checkpoint. " + currentCheckPoint);
            }
            chk.SetSprite();
        }
    }

    public bool AddCheckPoint(CheckPoint newCheckPoint)
    {
        if (!checkPoints.Contains(newCheckPoint.id))
        {
            Debug.Log("Id doesn't exist");
            checkPoints.Add(newCheckPoint.id);
            return true;
        }
        Debug.Log("Id does exist");
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
