using UnityEngine;
using UnityEngine.UI;
using OpenCvSharp;
using System.IO;
using System.Collections;
using System;

public class Opencv : MonoBehaviour
{
    public Mat image;
    public GameObject panel;
    public bool check = true;
    public Text text = null;
    string sDirPath;
    private byte[] imageByte;
    Texture2D tex;
    public int flag = 0;
    public static string[] list_of_furniture;
    public static int size_string;
    public static string[] list_color;
    public static string color = "";
    public static int num_color;
    //UnityEngine.Rect rect;

    private void Start()
    {
        tex = new Texture2D(1080, 1920, TextureFormat.RGB24, true);
    }

    private double abs(double a)
    {
        if (a < 0) a = (-1) * a;
        return a;
    }

    public void ScreenShot()
    {
        StartCoroutine(Shot());
    }

    WaitForEndOfFrame frameEnd = new WaitForEndOfFrame();

    public IEnumerator Shot()
    {
        yield return frameEnd;

        string myFilename = "myScreenshot" + ".png";
        string myDefaultLocation = Application.persistentDataPath + "/" + myFilename;
        string myFolderLocation = "/storage/emulated/0/DCIM/Screenshots/";
        string myScreenshotLocation = myFolderLocation + myFilename;
        text.text = myDefaultLocation + "   " + myScreenshotLocation;

        tex.ReadPixels(new UnityEngine.Rect(0, 0, 1080, 1920), 0, 0, true);
        tex.Apply();
        imageByte = tex.EncodeToPNG();

        File.WriteAllBytes(myDefaultLocation, imageByte);

        int width = 1080;
        int height = 1920;

        double[,] pixels = new double[height, width];

        int[] baseColor = new int[7];
        baseColor[0] = 3394611; baseColor[1] = 10040064; baseColor[2] = 16737792; baseColor[3] = 16777215; baseColor[4] = 6737151; baseColor[5] = 10000000; baseColor[6] = 16711833;
        int[] Color = new int[7];
        for (int i = 0; i < 7; i++) Color[i] = 0;

        //Debug.Log(image.Rows + " & " + image.Cols);
        int temp = 0;
        double min = 999999999;
        int k = 0;
        for (int pixel_y = 0; pixel_y < height; ++pixel_y)
        {
            for (int pixel_x = 0; pixel_x < width; ++pixel_x)
            {
                Color c = tex.GetPixel(pixel_x, pixel_y);
                string[] buffer = new string[4];
                sDirPath = c.ToString();
                sDirPath = sDirPath.Replace("RGBA(", ""); sDirPath = sDirPath.Replace(" ", ""); sDirPath = sDirPath.Replace(")", "");
                buffer = sDirPath.Split(',');
                pixels[pixel_y, pixel_x] = Convert.ToDouble(buffer[0]) * 255 * 16 * 16 * 16 * 16 + Convert.ToDouble(buffer[1]) * 255 * 16 * 16 + Convert.ToDouble(buffer[2]) * 255;

                for (k = 0; k < 7; k++)
                {
                    if (min > abs(pixels[pixel_y, pixel_x] - baseColor[k]))
                    {
                        min = abs(pixels[pixel_y, pixel_x] - baseColor[k]);
                        temp = k;
                    }
                }
                Color[temp]++; min = 999999999;
                //Debug.LogFormat("pixel[{0},{1}] = {2}", pixel_x, pixel_y, c);
            }
        }
        Color c1 = tex.GetPixel(1000, 1000);
        sDirPath = c1.ToString();
        //string[] buffer = new string[4];
        //sDirPath = sDirPath.Replace("RGBA(", ""); sDirPath = sDirPath.Replace(" ", ""); sDirPath = sDirPath.Replace(")", "");
        //buffer = sDirPath.Split(',');
        Debug.Log(sDirPath);
        for (int i = 0; i < 7; i++)
        {
            Debug.Log(i + " " + Color[i]);
        }

        int max = 0; temp = 0;
        for (int i = 0; i < 7; i++)
        {
            if (max < Color[i]) max = Color[i]; temp = i;
        }
        switch (temp)
        {
            case 0:
                color = "green";
                break;
            case 1:
                color = "brown";
                break;
            case 2:
                color = "orange";
                break;
            case 3:
                color = "white";
                break;
            case 4:
                color = "blue";
                break;
            case 5:
                color = "gray";
                break;
            case 6:
                color = "pink";
                break;
        }
        text.text = color;
        CallLogin();


        //Debug.Log("Capture Complete!");
    }

    //public InputField nameField;
    //public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("color", "pink");
        //Debug.Log(nameField.text);

        WWW www = new WWW("http://13.125.174.193/recommandaws.php", form);
        yield return www;
        if (www.text .Length>100)
        {
            Debug.Log(www.text);
            string temp_string = www.text.Replace("     [name]: ", "|");//12
            temp_string = temp_string.Replace("   color:", ",");//8
            size_string = (www.text.Length - temp_string.Length) / 20;
            list_of_furniture = new string[size_string + 1];
            list_of_furniture = temp_string.Split('|');
            string color = list_of_furniture[0];
            int temp_num = 0;
            color = color.Replace("Output color is   ", "");temp_num = color.Length; color = color.Replace("     ", "|");
            num_color = ((temp_num-color.Length)/4)+1;
            color = color.Replace(" ", "");
            list_color = new string[num_color];
            list_color = color.Split('|');
            for(int i = 0; i < num_color; i++)
            {
                Debug.Log(list_color[i]);
            }
            for (int i = 0; i < size_string; i++)
            {
                list_of_furniture[i] = list_of_furniture[i + 1];
            }
            for (int i = 0; i < size_string; i++)
            {
                list_of_furniture[i] = list_of_furniture[i].Substring(0, list_of_furniture[i].IndexOf(','));
            }
            for (int i = 0; i < size_string; i++)
            {
                Debug.Log(list_of_furniture[i]);
            }
            Debug.Log(temp_string);
            Debug.Log(num_color);
            UnityEngine.SceneManagement.SceneManager.LoadScene(58);
        }
        else
        {
            Debug.Log(www.text);
            Debug.Log("user login fail");
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

    }

    public int get_size_list()
    {
        return size_string;
    }

    public int get_size_num()
    {
        return num_color;
    }

    public string[] get_listof_furniture()
    {
        return list_of_furniture;
    }

    public string[] get_list_color()
    {
        return list_color;
    }
}


/*
    cout << "녹색 : " << Color[0] << " 개" << endl;
	cout << "진브라운 : " << Color[1] << " 개" << endl;
	cout << "오렌지 : " << Color[2] << " 개" << endl;
	cout << "검정색 : " << Color[3] << " 개" << endl;
	cout << "하늘색 : " << Color[4] << " 개" << endl;
	cout << "회색 : " << Color[5] << " 개" << endl;
	cout << "핑크색 : " << Color[6] << " 개" << endl;
	cout << "흰색 : " << Color[7] << " 개" << endl;
*/