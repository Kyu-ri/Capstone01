using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Favorite_Result : MonoBehaviour
{
    public GameObject[] bind = new GameObject[15];
    GameObject obj = null;
    public RawImage[] img = new RawImage[15];
    string category;
    string[] list_of_furniture;
    string[] list_of_url;
    int size_string=0;
    string url;
    //public Button button1;

    public void Put_item()//int count
    {
        obj = GameObject.Find("Result");
        Favorite sofa1 = obj.GetComponent<Favorite>();
        list_of_furniture = sofa1.get_listof_furniture();
        list_of_url = sofa1.get_listof_url();
        size_string = sofa1.get_size_list();
        Debug.Log(size_string);
        for (int i = 0; i < size_string; i++)
        {
            Debug.Log(list_of_furniture[i]);
        }
        for (int i = 1; i < 16; i++)
        {
            string temp = "Bind"; temp = temp + i.ToString();
            if (i < size_string + 1)
            {
                url = "http://13.125.174.193/" + list_of_furniture[i - 1] + ".PNG";
                Debug.Log(url);
                GameObject.Find(temp).GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = list_of_furniture[i - 1];
                StartCoroutine(LoadImageToUnity(i - 1));
            }
            else
            {
                GameObject.Find(temp).SetActive(false);
            }
        }
    }

    /*private void OnGUI()
    {
        GUI.Button(new Rect(15, 500, 400, 300), "HI");
    }*/

    public IEnumerator LoadImageToUnity(int i)
    {
        WWW W = new WWW(url);
        yield return W;
        Texture2D te = W.texture;
        img[i].texture = te;
    }

    public void button1Clicked()
    {
        if (size_string!=0)
        {
            Application.OpenURL(list_of_url[0]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button2Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 1)
        {
            Application.OpenURL(list_of_url[1]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button3Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 2)
        {
            Application.OpenURL(list_of_url[2]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button4Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 3)
        {
            Application.OpenURL(list_of_url[3]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button5Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 4)
        {
            Application.OpenURL(list_of_url[4]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button6Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 5)
        {
            Application.OpenURL(list_of_url[5]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button7Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 6)
        {
            Application.OpenURL(list_of_url[6]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button8Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 7)
        {
            Application.OpenURL(list_of_url[7]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button9Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 8)
        {
            Application.OpenURL(list_of_url[8]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button10Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 9)
        {
            Application.OpenURL(list_of_url[9]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button11Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 10)
        {
            Application.OpenURL(list_of_url[10]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button12Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 11)
        {
            Application.OpenURL(list_of_url[11]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button13Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 12)
        {
            Application.OpenURL(list_of_url[12]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button14Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 13)
        {
            Application.OpenURL(list_of_url[13]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    public void button15Clicked()
    {
        if (size_string != 0 && list_of_url.Length > 14)
        {
            Application.OpenURL(list_of_url[14]);
        }
        else
        {
            Debug.Log("no list");
        }
    }

    private void Start()
    {
        Put_item();
    }
}
