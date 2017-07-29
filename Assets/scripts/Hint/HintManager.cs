using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// When attached to a GameObject, a hint will be displayed when it collides with a
// GameObject that has the script 'Hint' attached to it. 
public class HintManager : MonoBehaviour {
    public GameObject UI_Hint;
    protected DateTime hintFirstShown;
    public string[] hints;

    private void Update() {
        DateTime now = DateTime.Now;
        TimeSpan lengthOfHint = (now - hintFirstShown).Duration();

        if (lengthOfHint.TotalSeconds >= 5) {
            UI_Hint.SetActive(false);
        }
    }

    protected void showHint(string msg) {
        hintFirstShown = DateTime.Now;
        UI_Hint.GetComponent<Text>().text = msg;
        UI_Hint.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Hint") {
            string hintMsg = hints[(other.GetComponent<Hint>().index)];
            showHint(hintMsg);
        }
    }
}
