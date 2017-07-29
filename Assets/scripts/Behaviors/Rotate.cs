using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float speed;
    public string direction;
    protected float speedToUse;
    public bool useDistanceMoved;
    protected float distanceTraveled;
    protected Vector2 lastPosition;
    public float diameter;

    private void Start() {
        lastPosition = transform.position;

        switch (direction) {
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

        if (direction == "right") {
            speedToUse = -speed;
        }
        else {
            speedToUse = speed;
        }

        if (useDistanceMoved) {
            // Rotation speed is determined by distance moved
            if (direction == "right") {
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
