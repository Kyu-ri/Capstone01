using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoToDrawer : MonoBehaviour
{

    public void Click_to_Drawer()
    {
        SceneManager.LoadScene(5);
    }
}
