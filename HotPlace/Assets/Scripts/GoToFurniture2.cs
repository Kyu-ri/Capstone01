using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoToFurniture2 : MonoBehaviour
{

    public RawImage raw_goToFurniture2;

    public void Click_to_Furniture2()
    {
        SceneManager.LoadScene(4);
    }
}
