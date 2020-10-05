using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recommend : MonoBehaviour {

	public void ScreenShot()
    {
        string sDirPath;
        sDirPath = Application.dataPath + "Screenshot.png";
        UnityEngine.ScreenCapture.CaptureScreenshot(sDirPath);
        Debug.Log("Capture Complete!");
    }
}
