using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NotifySubscriberOfCollision : MonoBehaviour {
    public UnityEvent[] e;
    public float delay; // milliseconds
    private bool collision;
    private bool triggered;
    private DateTime timeOfCollision;

    private void Start() {
        collision = false;
        triggered = false;
    }

    private void Update() {
        if (collision && triggered == false) {
            DateTime now = DateTime.Now;

            TimeSpan timespan = (now - timeOfCollision).Duration();
            if (timespan.TotalMilliseconds >= delay) {
                notifySubscribers();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        triggered = false;
        collision = true;
        timeOfCollision = DateTime.Now;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        triggered = false;
        collision = true;
        timeOfCollision = DateTime.Now;
    }

    private void notifySubscribers() {
        triggered = true;

        foreach (var sub in e) {
            sub.Invoke();
        }
    }
}
