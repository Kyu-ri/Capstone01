using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class living : MonoBehaviour
{

    public InputField widthField;
    public InputField lengthField;
    public InputField heightField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(livingsize());
    }

    IEnumerator livingsize()
    {
        WWWForm form = new WWWForm();

        form.AddField("lw", widthField.text);
        form.AddField("ll", lengthField.text);
        form.AddField("lh", heightField.text);

        Debug.Log(widthField.text);
        Debug.Log(lengthField.text);
        Debug.Log(heightField.text);

        WWW www = new WWW("http://wldbs1993.cafe24.com/living.php", form);
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

