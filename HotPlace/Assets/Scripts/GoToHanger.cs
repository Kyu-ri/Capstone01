using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoToHanger : MonoBehaviour
{

    public void Click_to_Hanger()
    {
        SceneManager.LoadScene(6);
    }
}
