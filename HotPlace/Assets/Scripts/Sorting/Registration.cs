using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Registration : MonoBehaviour {

    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();

        form.AddField("name",nameField.text);
        form.AddField("password",passwordField.text);

        WWW www = new WWW("http://13.125.174.193/insertaws.php", form);
        yield return www;

        Debug.Log(www.text);

        if(www.text.Substring(0,1).Equals("0"))

        {
            Debug.Log("faill");
            //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

        else
        {
            Debug.Log("create account successfully");
            //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 1 && passwordField.text.Length >= 1);
    }
	
}
