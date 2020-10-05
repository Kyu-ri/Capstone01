using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Act_Table : MonoBehaviour {

    GameObject obj = null;

    public void Click_to_Table1()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("JENBAN side table");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(51);
    }

    public void Click_to_Table2()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("JUSTIN table");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(53);
    }

    public void Click_to_Table3()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("OAKMILL table");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(54);
    }

    public void Click_to_Table4()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("PORTU round table");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(50);
    }

    public void Click_to_Table5()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("SALISBURY table");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(52);
    }

    public void goToFur()
    {
        SceneManager.LoadScene(4);
    }
}
