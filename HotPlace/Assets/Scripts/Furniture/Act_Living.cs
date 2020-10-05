using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Act_Living : MonoBehaviour {

    GameObject obj = null;

    public void Click_to_Living1()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("flowerpot");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(44);
    }

    public void Click_to_Living2()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("GRUET troli");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(45);
    }

    public void Click_to_Living3()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("LOMBO mat");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(13);
    }

    public void Click_to_Living4()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("SEEOT stand hanger");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(11);
    }

    public void Click_to_Living5()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("SHADARI hanger");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(12);
    }

    public void Click_to_Living6()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("TRUFUL cushion(green)");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(43);
    }

    public void Click_to_Living7()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("TRUFUL cushion(pink)     ");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(42);
    }

    public void gotoFur()
    {
        SceneManager.LoadScene(4);
    }
}
