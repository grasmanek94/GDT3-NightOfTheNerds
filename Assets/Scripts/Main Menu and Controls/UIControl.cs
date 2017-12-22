using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject LevelSelector;
    public GameObject EllieSelector;
    public GameObject PlayLevelBtn;
    public GameObject EllieContinueBtn;
    public Image Level1IMG;
    public Image Level2IMG;
    public Image SelectedLevel;
    public Text Level1txt;
    public Text Level2txt;
    public Text SelectedLevelText;
    public Text RouteSelectInstructionText;
    private string SceneName;

	void Start()
    {
        MainMenu.SetActive(true);
        LevelSelector.SetActive(false);
        EllieSelector.SetActive(false);
        Level1IMG.color = new Color(255, 255, 255, 50);
        Level1IMG.GetComponent<Button>().interactable = false;
        Level1txt.text = "locked";
        /*Level2IMG.color = new Color(255, 255, 255, 50);
        Level2IMG.GetComponent<Button>().interactable = false;
        Level2txt.text = "locked";*/
        PlayLevelBtn.SetActive(false);
        EllieContinueBtn.SetActive(false);
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
            SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
        }     
    }

    public void ev_EllieContinueBtn(Text Routename)
    {
        if (Routename.text != "Select Route")
        {
            EllieSelector.SetActive(false);
            LevelSelector.SetActive(true);
        }
    }

    public void ev_routeSelected()
    {
        EllieContinueBtn.SetActive(true);
        RouteSelectInstructionText.text = "";
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
        if (name == "Level 1")
        {
            Level1IMG.color = Color.white;
            Level1IMG.GetComponent<Button>().interactable = true;
            Level1txt.text = "Level 1";
        }

        else if (name == "Level 2")
        {
            Level2IMG.color = Color.white;
            Level2IMG.GetComponent<Button>().interactable = true;
            Level2txt.text = "Level 2";
        }
    }
}