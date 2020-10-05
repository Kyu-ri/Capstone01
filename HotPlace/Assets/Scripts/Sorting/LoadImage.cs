using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour {

    public RawImage img;
    private string url = "http://13.125.174.193/JENBAN side table.PNG";

    //http://13.125.174.193/flowerpot.PNG
    //http://13.125.174.193/ATEZA chair.PNG
    //http://13.125.174.193/BONSEN 2person sofabed.PNG
    //http://13.125.174.193/MENGOU 3person wood sofa.PNG
    //http://13.125.174.193/DEMIL 2person sofa.PNG
    //http://13.125.174.193/LOMBO mat.PNG
    //http://13.125.174.193/OMSTAD short light.PNG
    //http://13.125.174.193/SADARI hanger.PNG
    //http://13.125.174.193/SALISBURY table.PNG



    void Start () {

        StartCoroutine(LoadImageToUnity(img));
		
	}
	

    public IEnumerator LoadImageToUnity(RawImage img1)
    {

        WWW W = new WWW(url);
        yield return W;
        Texture2D te = W.texture;
        img.texture = te;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
