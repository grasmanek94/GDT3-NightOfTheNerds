using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;

public class QRController : MonoBehaviour
{

    private WebCamTexture webCamTexture;
    private Rect screenRect; // Rectangle in which the webcamtexture will be placed
    public string codeResult; // The decoded QR code

    // Use this for initialization
    void Start()
    {
        Application.RequestUserAuthorization(UserAuthorization.WebCam);
        screenRect = new Rect(0, 0, Screen.width, Screen.height);

        webCamTexture = new WebCamTexture();

        //sets height and width of the camera equal to that of the screen
        webCamTexture.requestedHeight = Screen.height;
        webCamTexture.requestedWidth = Screen.width;

        if (webCamTexture != null)
        {
            webCamTexture.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Is called for rendering and handling GUI events
    void OnGUI()
    {
        // Draws the camera to the screen
        if (webCamTexture != null)
        {
            GUI.DrawTexture(screenRect, webCamTexture, ScaleMode.ScaleToFit);
            GUI.depth = 1;
        }

        // Read the QR code with a barcodereader and decode it
        IBarcodeReader qrReader = new BarcodeReader();
        Result result = qrReader.Decode(webCamTexture.GetPixels32(), webCamTexture.width, webCamTexture.height);
        if (result != null)
        {
            Debug.Log("Check1");
            codeResult = result.Text;
        }


    }
}
