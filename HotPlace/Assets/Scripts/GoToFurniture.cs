using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoToFurniture : MonoBehaviour {

    GameObject obj = null;

    public void Click_to_Chair1()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("BABOBAB director chair");
        //Debug.Log(input.get_f urname());
        SceneManager.LoadScene(26);
    }

    public void Click_to_Chair2()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("BEKJE stool");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(29);
    }

    public void Click_to_Chair3()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("cube chair");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(27);
    }

    public void Click_to_Chair4()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("FERI stool");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(30);
    }

    public void Click_to_Chair5()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("FERI stool2");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(31);
    }

    public void Click_to_Chair6()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("PECRE  stool");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(32);
    }

    public void Click_to_Chair7()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("STANLEY");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(25);
    }

    public void Click_to_Chair8()
    {
        obj = GameObject.Find("InputFur");
        Login input = obj.GetComponent<Login>();
        input.set_furname("VALLEN");
        //Debug.Log(input.get_furname());
        SceneManager.LoadScene(28);
    }

    public void GotoFurniture()
    {
        SceneManager.LoadScene(3);
    }

    public void GotoSort()
    {
        SceneManager.LoadScene(18);
    }
    
}
