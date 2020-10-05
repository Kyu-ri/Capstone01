using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Act_Drawer : MonoBehaviour {

    GameObject obj = null;

    public void Click_to_Drawer1()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("TETOS drawer");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(9);
    }

    public void Click_to_Drawer2()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("MARONA drawer");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(10);
    }

    public void Click_to_Drawer5()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("FRIEM shelf");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(14);
    }

    public void Click_to_Drawer4()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("FIHA drawer");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(35);
    }

    public void Click_to_Drawer3()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("RENJY tray");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(36);
    }

    public void Click_to_Drawer6()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("MKB cabinet");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(34);
    }

}
