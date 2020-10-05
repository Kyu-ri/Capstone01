using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Act_Light : MonoBehaviour {

    GameObject obj = null;

    public void Click_to_Light1()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("ELROY light");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(39);
    }

    public void Click_to_Light2()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("FEBRIK light");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(41);
    }

    public void Click_to_Light3()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("OMSTAD short light");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(37);
    }

    public void Click_to_Light4()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("PRISA short light");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(38);
    }

    public void Click_to_Light5()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("RUSTA long light");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(40);
    }

    public void gotoFur()
    {
        SceneManager.LoadScene(4);
    }
}
