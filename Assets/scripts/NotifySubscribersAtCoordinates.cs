using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NotifySubscribersAtCoordinates : MonoBehaviour {
    public Vector2 target;
    public float distanceTrigger;
    protected bool triggered = false;
    public UnityEvent[] e;
    public bool triggerOnlyOnce = true;

    private void Update() {
        if (triggered == true && triggerOnlyOnce == true) {
            return;
        }

        float currentDistance = Vector2.Distance(target, transform.position);

        if (currentDistance <= distanceTrigger) {
            triggered = true;

            foreach (var sub in e) {
                sub.Invoke();
            }
        }
    }
}
