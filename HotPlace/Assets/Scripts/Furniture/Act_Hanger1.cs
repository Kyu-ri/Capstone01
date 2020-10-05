using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Act_Hanger1 : MonoBehaviour {

    GameObject obj = null;

    public void Click_to_Bed1()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("FIKK singlebed");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(23);
    }

    public void Click_to_Bed2()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("JOHN bed");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(24);
    }

    public void Click_to_Bed3()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("RISHULT singlebed");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(22);
    }

    public void Click_to_Bed4()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("RISHULT supersinglebed");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(21);
    }

}
