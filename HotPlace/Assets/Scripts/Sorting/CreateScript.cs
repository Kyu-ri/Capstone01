using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateScript : MonoBehaviour {

    public GameObject[] bind = new GameObject[15];
    GameObject obj = null;
    public RawImage[] img=new RawImage[15];
    string category;
    string[] list_of_furniture;
    int size_string;
    string url;
    //public Button button1;

    public void Put_item()//int count
    {
        obj = GameObject.Find("Test");
        sofa sofa1 = obj.GetComponent<sofa>();
        category = sofa1.get_category();
        Debug.Log(category);
        list_of_furniture = sofa1.get_listoffurniture();
        size_string = sofa1.get_size_list();
        Debug.Log(size_string);
        for (int i = 0; i < size_string; i++)
        {
            Debug.Log(list_of_furniture[i]);
        }
        for (int i = 1; i < 16; i++)
        {
            string temp = "Bind"; temp = temp + i.ToString();
            if (i <size_string+1)
            {
                url = "http://13.125.174.193/" + list_of_furniture[i - 1] + ".PNG";
                //Debug.Log(url);
                GameObject.Find(temp).GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = list_of_furniture[i-1];
                StartCoroutine(LoadImageToUnity(i-1));  
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

    private void Start()
    {
        Put_item();
    }
}
