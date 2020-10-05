using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sofa : MonoBehaviour
{
    public InputField widthField;
    public InputField lengthField;
    public InputField heightField;
    public static string[] list_of_furniture= { };
    public static string category = "";
    public static int size_string =0;
    GameObject obj = null;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(sofasize());
    }

    IEnumerator sofasize()
    {
        obj = GameObject.Find("Category");
        GoInputMenu input = obj.GetComponent<GoInputMenu>();
        string temp_category = "http://13.125.174.193/"+input.get_category() + "aws.php";
        Debug.Log(temp_category);
        WWWForm form = new WWWForm();

        form.AddField("sw",widthField.text);
        form.AddField("sl",lengthField.text);
        form.AddField("sh",heightField.text);

        Debug.Log(widthField.text);
        Debug.Log(lengthField.text);
        Debug.Log(heightField.text);

        WWW www = new WWW(temp_category, form);
        yield return www;

        Debug.Log(www.text);

        if (www.text == "0 result")
        {
            Debug.Log("faill");
        }

        else
        {
            string temp_string = www.text.Replace("name: ", "|");
            size_string = (www.text.Length - temp_string.Length) / 5;
            temp_string = temp_string.Replace(" width", ",");
            temp_string = temp_string.Replace("height", "`");
            //Debug.Log(temp_string);
            list_of_furniture = new string[size_string];
            list_of_furniture = temp_string.Split('`');
            for (int i = 0; i < size_string; i++)
            {
                list_of_furniture[i] = list_of_furniture[i].Substring(list_of_furniture[i].IndexOf('|') + 1, list_of_furniture[i].IndexOf(',') - list_of_furniture[i].IndexOf('|') - 1);
                Debug.Log(list_of_furniture[i]);
            }
            Debug.Log("successfully");
            category = input.get_category();
            UnityEngine.SceneManagement.SceneManager.LoadScene(16);
        }
    }

    public string[] get_listoffurniture()
    {
        return list_of_furniture;
    }

    public string get_category()
    {
        return category;
    }

    public int get_size_list()
    {
        return size_string;
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (widthField.text.Length >= 0);
    }

    public void return_menu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(18);
    }

}
