using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NerdOfTheNight;

public class Door : MonoBehaviour {

    [SerializeField]
    private GameObject open;
    [SerializeField]
    private GameObject closed;

    private QRController qr_controller;
    private WebTalk webtalk;

    public void Start()
    {
        if (webtalk == null)
        {
            webtalk = new WebTalk();
            webtalk.OnScoreAdded += OnScoreAdded;
            webtalk.OnScoreFailed += OnScoreFailed;
        }
        qr_controller = GetComponent<QRController>();
        qr_controller.enabled = false;
        qr_controller.OnQRCodeScanned += OnQRCodeScanned;
    }

    private void OnScoreFailed(WebTalk obj, string score)
    {
        Debug.Log("Failed to unlock score: " + score);
    }

    private void OnScoreAdded(WebTalk obj, string score)
    {
        // add score to global unlock list
        Debug.Log("Unlocked score: " + score);
        Open();
    }

    private void OnQRCodeScanned(QRController obj, string code)
    {
        if(webtalk.is_code_level_unlock(code))
        {
            qr_controller.enabled = false;
            webtalk.add_score(code);
        }
    }

    // Use this for initialization
    public void Open () {
        closed.SetActive(false);
        open.SetActive(true);
    }
	
	// Update is called once per frame
	public void Close ()
    {
        open.SetActive(false);
        closed.SetActive(true);
    }

    public bool IsOpen()
    {
        return open.activeSelf;
    }

    public bool IsClosed()
    {
        return closed.activeSelf;
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Door Enter");
        if(!IsOpen())
        {
            qr_controller.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Door Leave");
        qr_controller.enabled = false;
    }
}
