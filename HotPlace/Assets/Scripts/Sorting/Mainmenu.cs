using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour {

    public void GoToRegister()
    {
        SceneManager.LoadScene(1);
    }


    public void GoToLiving()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToLight()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToTable()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToBed()
    {
        SceneManager.LoadScene(6);
    }

    public void GoToChair()
    {
        SceneManager.LoadScene(5);
    }
}
