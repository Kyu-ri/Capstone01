using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class checksize : MonoBehaviour {

   
    public InputField nameField;

    public Button submitButton;

    public void CallSize()
    {

        StartCoroutine(CheckSize());
    }

    IEnumerator CheckSize()
    {
        WWWForm form = new WWWForm();

        form.AddField("size", nameField.text);
      


        WWW www = new WWW("http://localhost/soochi.php", form);
        yield return www;


        if (www.text == "0")

        {

            Debug.Log("faill");
           

        }

        else
        {

            Debug.Log("create account successfully");
            
        }

    }

    public void VerifyInputs()
    {

        submitButton.interactable = (nameField.text.Length >= 1);


    }




}
