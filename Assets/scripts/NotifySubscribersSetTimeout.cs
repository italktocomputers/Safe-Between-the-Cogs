using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NotifySubscribersSetTimeout : MonoBehaviour {
    public UnityEvent[] e;
    public int timeout; // milliseconds
    private DateTime startTime;

    void Start() {
        startTime = DateTime.Now;
    }

    void Update() {
        DateTime now = DateTime.Now;

        TimeSpan timespan = (now - startTime).Duration();
        if (timespan.TotalMilliseconds >= timeout) {
            notify();
            enabled = false;
        }
    }

    private void notify() {
        foreach (var sub in e) {
            sub.Invoke();
        }
    }
}
