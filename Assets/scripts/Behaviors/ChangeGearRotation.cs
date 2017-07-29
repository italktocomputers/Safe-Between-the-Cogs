using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGearRotation : MonoBehaviour {
    public Vector2 start;
    public Vector2 finish;

    private void Update () {
        float distanceFromStart = Vector2.Distance(transform.position, start);
        float distanceFromFinish = Vector2.Distance(transform.position, finish);

        if (distanceFromFinish == 0.0f) {
            GetComponent<Rotate>().direction = "left";
        }

        if (distanceFromStart == 0.0f) {
            GetComponent<Rotate>().direction = "right";
        }
    }
}
