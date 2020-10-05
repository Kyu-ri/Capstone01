using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PopupController : MonoBehaviour {
    public void Click()
    {
        /*DialogDataAlert alert = new DialogDataAlert("Welcome", "Lets start", delegate ()
        {
            Debug.Log("OK!");
        });
        DialogManager.Instance.Push(alert);*/
        SceneManager.LoadScene(2);
    }
}
