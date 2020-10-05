using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Login : MonoBehaviour {

    public InputField nameField;
    public InputField passwordField;
    public Button submitButton;
    public static string user_name="";
    public static string furniture_name="";
    GameObject set_user_name = null;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
        //SceneManager.LoadScene(1);
    }


    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();

        form.AddField("checkname", nameField.text);
        form.AddField("checkpassword", passwordField.text);
       

        //Debug.Log(nameField.text);

        WWW www = new WWW("http://13.125.174.193/loginplzaws.php", form);
        yield return www;

        Debug.Log(www.text);
        //Debug.Log(www.text.Length);
        if (www.text.Length<9) 
        {
            user_name = nameField.text;
            Debug.Log(user_name);
            Debug.Log("SUccess!");

            set_user_name = GameObject.Find("set_user_name");
            Favorite favor = set_user_name.GetComponent<Favorite>();
            favor.set_user_name(nameField.text);

            SceneManager.LoadScene(1);

        }
        else
        {
            Debug.Log("user login fail");
        }
    }
    public void VerifyInputs()
        {
            submitButton.interactable = (nameField.text.Length >= 1);
        }

    public string get_username()
    {
        return user_name;
    }

    public string get_furname()
    {
        return furniture_name;
    }

    public void set_furname(string name)
    {
        furniture_name = name;
    }

}
