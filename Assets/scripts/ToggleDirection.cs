using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDirection : MonoBehaviour {
    public string[] directions;
    private int index = 0;

    public void toggle() {
        Direction direction = gameObject.GetComponent<Direction>();

        if (index == directions.Length) {
            index = 0;
        }

        direction.value = directions[index++];
    }
}
