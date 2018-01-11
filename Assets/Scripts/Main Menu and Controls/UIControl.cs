using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using NerdOfTheNight;

public class UIControl : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject LevelSelector;
    public GameObject EllieSelector;
    public GameObject PlayLevelBtn;
    public GameObject ScanQRBtn;
    public Image Level1IMG;
    public Image Level2IMG;
    public Image SelectedLevel;
    public Text Level1txt;
    public Text Level2txt;
    public Text SelectedLevelText;

    private QRController qr_controller;
    private string SceneName;
    private WebTalk webtalk;

    private class level_info
    {
        public string name;
        public Image img;
        public Text txt;
        public bool unlocked;

        public level_info(string name_, Image img_, Text txt_, bool unlocked_)
        {
            name = name_;
            img = img_;
            txt = txt_;
            unlocked = unlocked_;
        }

        public void Unlock()
        {
            img.color = Color.white;
            img.GetComponent<Button>().interactable = true;
            txt.text = name;
        }
    }

    private level_info[] Levels;

    private GameManager gamemanager;

	void Start()
    {
        Levels = new level_info[2];
        if (webtalk == null)
        {
            webtalk = new WebTalk();
            webtalk.OnScoreAdded += OnScoreAdded;
            webtalk.OnScoreFailed += OnScoreFailed;
        }

        MainMenu.SetActive(true);
        LevelSelector.SetActive(false);
        EllieSelector.SetActive(false);
        Level1IMG.color = new Color(255, 255, 255, 50);
        Level1IMG.GetComponent<Button>().interactable = false;
        Level1txt.text = "locked";
        Levels[0] = new level_info("Level 1", Level1IMG, Level1txt, false);
        /*Level2IMG.color = new Color(255, 255, 255, 50);
        Level2IMG.GetComponent<Button>().interactable = false;
        Level2txt.text = "locked";
        Levels[1] = new level_info("Level 2", Level2IMG, Level2txt, false);*/
        PlayLevelBtn.SetActive(false);

        ScanQRBtn.SetActive(true);
        qr_controller = ScanQRBtn.GetComponent<QRController>();
        qr_controller.enabled = false;
        qr_controller.OnQRCodeScanned += OnQRCodeScanned;

        try
        {
            gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        catch
        {
            gamemanager = null;
        }
    }
	
	void Update()
    {
		
	}

    public void ev_ExitGameBtn()
    {
        Application.Quit();
    }

    public void ev_StartGameBtn()
    {
        MainMenu.SetActive(false);
        EllieSelector.SetActive(true);
    }

    public void ev_ReturnToMainBtn()
    {
        LevelSelector.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void ev_PlayLevelBtn()
    {
        if (!string.IsNullOrEmpty(SceneName))
        {
            gamemanager.currentCheckPoint = -1;
            SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
        }     
    }

    public void ev_EllieContinueBtn()
    {
         EllieSelector.SetActive(false);
         LevelSelector.SetActive(true);
    }
    
    public void SelectLevel(Image level)
    {
        SelectedLevel.color = Color.white;
        SelectedLevel.sprite = level.sprite;
        PlayLevelBtn.SetActive(true);
        SceneName = level.GetComponentInChildren<Text>().text;
    }

    public void UnlockLevel(string name)
    {
        for(int i = 0; i < Levels.Length; ++i)
        {
            if (Levels[i].name == name)
            {
                Levels[i].Unlock();
                return;
            }
        }
    }

    public void UnlockNextLevel()
    {
        for (int i = 0; i < Levels.Length; ++i)
        {
            if (!Levels[i].unlocked)
            {
                Levels[i].Unlock();
                return;
            }
        }
    }

    public void ev_ScanQRBtn()
    {
        qr_controller.enabled = true;
    }

    private void OnScoreFailed(WebTalk obj, string score)
    {
        Debug.Log("Failed to unlock score: " + score);
    }

    private void OnScoreAdded(WebTalk obj, string score)
    {
        // add score to global unlock list
        Debug.Log("Unlocked score: " + score);
        UnlockNextLevel();
    }

    private void OnQRCodeScanned(QRController obj, string code)
    {
        if (webtalk.is_code_level_unlock(code))
        {
            qr_controller.enabled = false;
            webtalk.add_score(code);
        }
    }
}