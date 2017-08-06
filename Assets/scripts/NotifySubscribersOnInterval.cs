using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NotifySubscribersOnInterval : MonoBehaviour {
    public UnityEvent[] e;
    public int interval; // milliseconds
    private DateTime startTime;

    void Start () {
        startTime = DateTime.Now;
	}
	
	void Update () {
        DateTime now = DateTime.Now;

        TimeSpan timespan = (now - startTime).Duration();
        if (timespan.TotalMilliseconds >= interval) {
            notify();
            startTime = DateTime.Now;
        }
    }

    private void notify() {
        foreach (var sub in e) {
            sub.Invoke();
        }
    }
}
