using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSetup : MonoBehaviour
{
    public Camera camOne;
    public Camera camTwo;

    public Material matOne;
    public Material matTwo;


    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1024, 512, false);

        /*if (camTwo.targetTexture != null){
                camTwo.targetTexture.Release();
        }

        camTwo.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        matTwo.mainTexture = camTwo.targetTexture;*/
    }

}
