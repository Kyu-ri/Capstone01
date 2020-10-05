using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bed : MonoBehaviour
{
    public InputField widthField;
    public InputField lengthField;
    public InputField heightField;

    public Button submitButton;

    public void CallRegister()
    { 
        StartCoroutine(bedsize());
    }

    IEnumerator bedsize()
    {
        WWWForm form = new WWWForm();

        form.AddField("bw", widthField.text);
        form.AddField("bl", lengthField.text);
        form.AddField("bh", heightField.text);

        Debug.Log(widthField.text);
        Debug.Log(lengthField.text);
        Debug.Log(heightField.text);

        WWW www = new WWW("http://wldbs1993.cafe24.com/bed.php", form);
        yield return www;

        Debug.Log(www.text);

        if (www.text == "0 result")
        {
            Debug.Log("faill");
        }

        else
        {
            Debug.Log("successfully");
        }

    }

    public void VerifyInputs()
    {
        submitButton.interactable = (widthField.text.Length >= 0);
    }
}

