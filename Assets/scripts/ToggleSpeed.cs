using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpeed : MonoBehaviour {
    public float[] speeds;
    private int index = 0;

    public void toggle() {
        Speed speed = gameObject.GetComponent<Speed>();

        if (index == speeds.Length) {
            index = 0;
        }

        speed.value = speeds[index++];
    }
}
