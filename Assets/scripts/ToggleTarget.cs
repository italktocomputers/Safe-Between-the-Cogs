using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTarget : MonoBehaviour {
    public Vector2[] targets;
    private int index = 0;

    public void toggle() {
        Target target = gameObject.GetComponent<Target>();

        if (index == targets.Length) {
            index = 0;
        }

        target.value = targets[index++];
    }
}
