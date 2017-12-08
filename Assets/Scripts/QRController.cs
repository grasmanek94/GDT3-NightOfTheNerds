using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;

public class QRController : MonoBehaviour
{
    public delegate void QRCodeScanned(QRController qr_controller, string code);
    public event QRCodeScanned OnQRCodeScanned;

    private WebCamTexture webCamTexture;
    private IBarcodeReader qrReader;
    private Rect screenRect; // Rectangle in which the webcamtexture will be placed
    public string codeResult; // The decoded QR code

    // Use this for initialization
    private void OnEnable()
    {
        screenRect = new Rect(0, 0, Screen.width, Screen.height);

        webCamTexture = new WebCamTexture();

        //sets height and width of the camera equal to that of the screen
        webCamTexture.requestedHeight = Screen.height;
        webCamTexture.requestedWidth = Screen.width;

        if (webCamTexture != null)
        {
            webCamTexture.Play();
            qrReader = new BarcodeReader();
        }
    }

    private void OnDisable()
    {
        if (webCamTexture != null)
        {
            webCamTexture.Stop();
        }
    }

    //Is called for rendering and handling GUI events
    void OnGUI()
    {
        if (OnQRCodeScanned != null && webCamTexture != null && webCamTexture.isPlaying)
        {
            // Draws the camera to the screen
            GUI.DrawTexture(screenRect, webCamTexture, ScaleMode.ScaleToFit);

            // Read the QR code with a barcodereader and decode it
            try
            {
                
                Result result = qrReader.Decode(webCamTexture.GetPixels32(), webCamTexture.width, webCamTexture.height);
                if (result != null)
                {
                    codeResult = result.Text;
                    OnQRCodeScanned(this, result.Text);
                }
            }
            catch (Exception ex)
            {
                Debug.Log(ex.Message);
            }
        }
    }
}
