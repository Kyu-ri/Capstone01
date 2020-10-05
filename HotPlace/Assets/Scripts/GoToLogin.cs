using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoToLogin : MonoBehaviour
{
    public RawImage raw_goToMain;

    public void Click_to_Login()
    {
        SceneManager.LoadScene(0);
    }
}
