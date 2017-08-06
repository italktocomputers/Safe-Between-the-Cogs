using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public Vector2 value;

    public void setTarget(Vector2 target) {
        value = target;
    }
}
