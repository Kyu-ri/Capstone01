using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class light : MonoBehaviour
{
    public InputField widthField;
    public InputField lengthField;
    public InputField heightField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(lightsize());
    }

    IEnumerator lightsize()
    {
        WWWForm form = new WWWForm();
        
        form.AddField("liw", widthField.text);
        form.AddField("lil", lengthField.text);
        form.AddField("lih", heightField.text);

        Debug.Log(widthField.text);
        Debug.Log(lengthField.text);
        Debug.Log(heightField.text);

        WWW www = new WWW("http://wldbs1993.cafe24.com/light.php", form);
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

