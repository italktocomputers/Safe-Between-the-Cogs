using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Jumbotron : MonoBehaviour {
    public GameObject textMessageLabel;
    public Image jumbotronImage;
    protected DateTime lastTimeTextMessageShown;
    protected Queue textMessageQueue = new Queue();

    private void Update () {
        DateTime now = DateTime.Now;
        TimeSpan lastTextMessageShown_timespan = (now - lastTimeTextMessageShown).Duration();

        if (lastTextMessageShown_timespan.TotalSeconds >= 2) {
            Text label = textMessageLabel.GetComponent<Text>();

            if (textMessageQueue.Count > 0) {
                jumbotronImage.enabled = true;
                label.text = textMessageQueue.Peek().ToString();
                textMessageQueue.Dequeue();
                lastTimeTextMessageShown = DateTime.Now;
            }
            else {
                label.text = "";
                jumbotronImage.enabled = false;
            }
        }
    }

    public void add(string message) {
        textMessageQueue.Enqueue(message);
    }
}
