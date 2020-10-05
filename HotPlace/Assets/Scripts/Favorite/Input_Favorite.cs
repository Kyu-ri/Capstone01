using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Favorite : MonoBehaviour {

    GameObject obj = null;
    GameObject Favor = null;
    public string user_name;
    public string furname;
    public int flag = 0;

    private void Start()
    {
        obj = GameObject.Find("Favorite");
        Login favorite = obj.GetComponent<Login>();
        user_name = favorite.get_username();
        furname = favorite.get_furname();

        Favor = GameObject.Find("Check");
        Favorite favor = Favor.GetComponent<Favorite>();
        string[] temp_string = new string[favor.get_size_list()];
        favor.update_State();
        temp_string = favor.get_listof_furniture();
        for (int i = 0; i < favor.get_size_list(); i++)
        {
            if (temp_string[i] == furname) flag = 1;
        }

        if (flag == 1)
        {
            GameObject.Find("Bind").GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "찜목록 해제";
        }
        else if (flag == 0)
        {
            GameObject.Find("Bind").GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "찜 하기";
        }
    }

    private void Update()
    {
        obj = GameObject.Find("Favorite");
        Login favorite = obj.GetComponent<Login>();
        user_name = favorite.get_username();
        furname = favorite.get_furname();

        Favor = GameObject.Find("Check");
        Favorite favor = Favor.GetComponent<Favorite>();
        string[] temp_string = new string[favor.get_size_list()];
        favor.update_State();
        temp_string = favor.get_listof_furniture();
        /*for (int i = 0; i < favor.get_size_list(); i++)
        {
            if (temp_string[i] == furname) flag = 1;
        }*/

        if (flag == 1)
        {
            GameObject.Find("Bind").GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "찜목록 해제";
        }
        else if (flag == 0)
        {
            GameObject.Find("Bind").GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "찜 하기";
        }
    }

    public void Favorite()
    {
        if (flag==0)
        {
            GameObject.Find("Bind").GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "찜목록 해제";
            flag = 1;
            StartCoroutine(Register());
        }
        else if (flag==1)
        {
            GameObject.Find("Bind").GetComponentInChildren<Button>().GetComponentInChildren<Text>().text="찜 하기";
            flag = 0;
            StartCoroutine(DeRegister());
        }
        else
        {
            Debug.Log("아무것도 아니자너~");
        }
        Favor = GameObject.Find("Check");
        Favorite favor = Favor.GetComponent<Favorite>();
        favor.update_State();
        Debug.Log(favor.get_size_list());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();

        form.AddField("name", user_name);

        form.AddField("fname", furname);

        WWW www = new WWW("http://13.125.174.193/favorite.php", form);
        yield return www;

        if (www.text == "0")
        {
            Debug.Log("faill");
        }

        else
        {
            Debug.Log("Succes");
        }
    }

    IEnumerator DeRegister()
    {
        WWWForm form = new WWWForm();

        form.AddField("name", user_name);

        form.AddField("fname", furname);

        WWW www = new WWW("http://13.125.174.193/deletee.php", form);
        yield return www;

        if (www.text == "0")
        {
            Debug.Log("faill");
        }

        else
        {
            Debug.Log("Succes");
        }
    }
}
