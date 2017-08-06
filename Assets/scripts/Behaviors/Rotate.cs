using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    protected float speedToUse;
    public bool useDistanceMoved;
    protected float distanceTraveled;
    protected Vector2 lastPosition;
    public float diameter;

    private void Start() {
        if (GetComponent<Speed>() == null) {
            throw new System.Exception("Object must have a Speed Component!");
        }

        if (GetComponent<Direction>() == null) {
            throw new System.Exception("Object must have a Target Component!");
        }

        lastPosition = transform.position;

        switch (GetComponent<Direction>().value) {
            case "left":
            case "right":
                break;
            default:
                throw new System.Exception("Direction can only be 'left' or 'right'.");
        }
    }

    private void Update() {
        distanceTraveled = Vector2.Distance(transform.position, lastPosition);
        lastPosition = transform.position;

        if (GetComponent<Direction>().value == "right") {
            speedToUse = -GetComponent<Speed>().value;
        }
        else {
            speedToUse = GetComponent<Speed>().value;
        }

        if (useDistanceMoved) {
            // Rotation speed is determined by distance moved
            if (GetComponent<Direction>().value == "right") {
                transform.Rotate(0.0f, 0.0f, -((distanceTraveled / (diameter * 3.14f) * 360)));
            } 
            else {
                transform.Rotate(0.0f, 0.0f, ((distanceTraveled / (diameter * 3.14f) * 360)));
            }
        }
        else {
            // Static rotation speed
            transform.Rotate(0.0f, 0.0f, ((Time.deltaTime) * speedToUse));
        }
    }
}
