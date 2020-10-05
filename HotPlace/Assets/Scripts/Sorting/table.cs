using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class table : MonoBehaviour
{

    public InputField widthField;
    public InputField lengthField;
    public InputField heightField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(tablesize());
    }

    IEnumerator tablesize()
    {
        WWWForm form = new WWWForm();

        form.AddField("tw", widthField.text);
        form.AddField("tl", lengthField.text);
        form.AddField("th", heightField.text);

        Debug.Log(widthField.text);
        Debug.Log(lengthField.text);
        Debug.Log(heightField.text);


        WWW www = new WWW("http://wldbs1993.cafe24.com/table.php", form);
        yield return www;

        Debug.Log(www.text);

        if (www.text == "0 result")
        {
            Debug.Log("faill");
            //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
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

