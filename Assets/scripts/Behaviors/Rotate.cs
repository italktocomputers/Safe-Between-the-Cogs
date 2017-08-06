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
    }

    private void Update() {
        distanceTraveled = Vector2.Distance(transform.position, lastPosition);
        lastPosition = transform.position;

        if (GetComponent<Direction>().value == DirectionUnit.Clockwise) {
            speedToUse = -GetComponent<Speed>().value;
        }
        else {
            speedToUse = GetComponent<Speed>().value;
        }

        if (useDistanceMoved) {
            // Rotation speed is determined by distance moved
            if (GetComponent<Direction>().value == DirectionUnit.Clockwise) {
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
