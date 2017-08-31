using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextToImage: MonoBehaviour {
    Dictionary<string, Sprite> map;
    
    public TextToImage() {
        Texture2D t0 = new Texture2D(138, 155);
        t0.LoadImage(System.IO.File.ReadAllBytes("assets/images/Number_0.png"));

        //SImage nl0 = Image.
        //nl0.spr


        //map.Add("0", new Sprite()
    }
    /*
    public Sprite stringToImages(string str) {

    }

    public Sprite charToImage(char str) {

    }
    */
}
