using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoToShelf : MonoBehaviour
{

    public void Click_to_Shelf()
    {
        SceneManager.LoadScene(8);
    }

    public void Click_to_Table()
    {
        SceneManager.LoadScene(55);
    }

    public void Click_to_Living()
    {
        SceneManager.LoadScene(56);
    }

    public void Click_to_Light()
    {
        SceneManager.LoadScene(57);
    }
}
