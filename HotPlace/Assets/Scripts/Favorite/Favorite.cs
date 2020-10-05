using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Favorite : MonoBehaviour
{
    public Text nameField;

    public Button submitButton;

    public static int flag = 0;
    public static string[] list_of_url = { };
    public static string[] list_of_furniture = { };
    public static string category = "";
    public static int size_string = 0;
    public static string user_name="";

    private void Start()
    {
        if(nameField!=null) nameField.text = user_name;
        StartCoroutine(LoginPlayer_Start());
    }

    public void update_State()
    {
        StartCoroutine(LoginPlayer_Start());
        Debug.Log("UPDATE Success!");
    }

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();

        form.AddField("name", nameField.text);

        Debug.Log("User: "+nameField.text);

        WWW www = new WWW("http://13.125.174.193/new.php", form);
        yield return www;
        Debug.Log(www.text);

        if (www.text.Substring(0,1) != "0")
        {
            //Debug.Log("Login Success!");
            Debug.Log(www.text);
            string temp_string = www.text.Replace("favorite: ", "|");
            size_string = (www.text.Length - temp_string.Length) / 9;
            temp_string = temp_string.Replace(" url: ", "`");
            temp_string = temp_string.Replace("[name]: ", ",");
            Debug.Log(temp_string);
            Debug.Log(size_string);
            list_of_furniture = new string[size_string+1];
            list_of_url = new string[size_string];
            list_of_furniture = temp_string.Split('|');
            for(int i = 0; i < size_string; i++)
            {
                list_of_furniture[i] = list_of_furniture[i + 1];
            }
            for (int i = 0; i < size_string; i++)
            {
                if (list_of_furniture[i].IndexOf(",") == -1)
                {
                    list_of_url[i] = list_of_furniture[i].Substring(list_of_furniture[i].IndexOf('`') + 1, list_of_furniture[i].Length - list_of_furniture[i].IndexOf('`') - 2);
                    list_of_furniture[i] = list_of_furniture[i].Substring(0, list_of_furniture[i].IndexOf('`'));
                }
                else
                {
                    list_of_url[i] = list_of_furniture[i].Substring(list_of_furniture[i].IndexOf('`') + 1, list_of_furniture[i].IndexOf(",") - list_of_furniture[i].IndexOf('`') - 1);
                    list_of_furniture[i] = list_of_furniture[i].Substring(0, list_of_furniture[i].IndexOf('`'));
                }
                Debug.Log(list_of_furniture[i]);
                Debug.Log(list_of_url[i]);
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene(19);
        }
        else
        {
            Debug.Log("user login fail");
            UnityEngine.SceneManagement.SceneManager.LoadScene(19);
        }
    }

    IEnumerator LoginPlayer_Start()
    {
        WWWForm form = new WWWForm();

        form.AddField("name", user_name);

        WWW www = new WWW("http://13.125.174.193/new.php", form);
        yield return www;

        if (www.text.Substring(0, 1) != "0")
        {
            string temp_string = www.text.Replace("favorite: ", "|");
            size_string = (www.text.Length - temp_string.Length) / 9;
            temp_string = temp_string.Replace(" url: ", "`");
            temp_string = temp_string.Replace("[name]: ", ",");
            list_of_furniture = new string[size_string + 1];
            list_of_url = new string[size_string];
            list_of_furniture = temp_string.Split('|');
            for (int i = 0; i < size_string; i++)
            {
                list_of_furniture[i] = list_of_furniture[i + 1];
            }
            for (int i = 0; i < size_string; i++)
            {
                if (list_of_furniture[i].IndexOf(",") == -1)
                {
                    list_of_url[i] = list_of_furniture[i].Substring(list_of_furniture[i].IndexOf('`') + 1, list_of_furniture[i].Length - list_of_furniture[i].IndexOf('`') - 2);
                    list_of_furniture[i] = list_of_furniture[i].Substring(0, list_of_furniture[i].IndexOf('`'));
                }
                else
                {
                    list_of_url[i] = list_of_furniture[i].Substring(list_of_furniture[i].IndexOf('`') + 1, list_of_furniture[i].IndexOf(",") - list_of_furniture[i].IndexOf('`') - 1);
                    list_of_furniture[i] = list_of_furniture[i].Substring(0, list_of_furniture[i].IndexOf('`'));
                }
            }
        }
        else
        {
            size_string = 0;
            Debug.Log("no Result");
        }
    }

    public int get_size_list()
    {
        return size_string;
    }

    public string[] get_listof_furniture()
    {
        return list_of_furniture;
    }

    public string[] get_listof_url()
    {
        return list_of_url;
    }

    public string get_username()
    {
        Debug.Log(user_name);
        return user_name;
    }

    public void get_test()
    {
        Debug.Log(get_username());
    }

    public void set_user_name(string temp)
    {
        user_name = temp;
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 1);
    }
}