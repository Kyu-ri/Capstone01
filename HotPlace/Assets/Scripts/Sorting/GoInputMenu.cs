using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoInputMenu : MonoBehaviour
{
    public static string category = "";
    public void GotoInput_Sofa()
    {
        category = "sofa";
        SceneManager.LoadScene(17);
    }
    public void GotoInput_Living()
    {
        category = "living";
        SceneManager.LoadScene(17);
    }
    public void GotoInput_Table()
    {
        category = "table";
        SceneManager.LoadScene(17);
    }
    public void GotoInput_Light()
    {
        category = "light";
        SceneManager.LoadScene(17);
    }
    public void GotoInput_Bed()
    {
        category = "bed";
        SceneManager.LoadScene(17);
    }
    public void GotoInput_Chair()
    {
        category = "chair";
        SceneManager.LoadScene(17);
    }

    public void GotoInput_Drawer()
    {
        category = "drawer";
        SceneManager.LoadScene(17);
    }

    public string get_category()
    {
        return category;
    }

}