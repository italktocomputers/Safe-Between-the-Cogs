using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NotifySubscriberOfCollision : MonoBehaviour {
    public UnityEvent[] e;

    private void OnTriggerEnter2D(Collider2D other) {
        foreach (var sub in e) {
            sub.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        foreach (var sub in e) {
            sub.Invoke();
        }
    }
}
