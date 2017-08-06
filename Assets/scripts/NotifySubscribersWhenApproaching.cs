using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Notify subscribers when specified GameObject approaches this GameObject
// at distance specified.
public class NotifySubscribersWhenApproaching : MonoBehaviour {
    public GameObject other;
    public float distanceTrigger;
    protected bool triggered = false;
    public UnityEvent[] e;

    private void Update () {
        if (triggered == false) {
            float currentDistance = Vector2.Distance(other.transform.position, transform.position);

            if (currentDistance <= distanceTrigger) {
                triggered = true;

                foreach (var sub in e) {
                    sub.Invoke();
                }
            }
        }
    }
}
