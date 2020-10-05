using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Act_Mat : MonoBehaviour {

    GameObject obj = null;

    public void Click_to_Sofa1()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("ATEZA chair");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(49);
    }

    public void Click_to_Sofa2()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("BONESEN 2person sofabed");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(46);
    }

    public void Click_to_Sofa3()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("DEMIL 2person sofa");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(47);
    }

    public void Click_to_Sofa4()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("MENGOU 3person wood sofa");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(48);
    }
}
