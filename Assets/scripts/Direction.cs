using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum DirectionUnit {
    Clockwise,
    Counterclockwise
}

public class Direction : MonoBehaviour {
    public DirectionUnit value;

    public void setDirection(DirectionUnit direction) {
        value = direction;
    }
}
