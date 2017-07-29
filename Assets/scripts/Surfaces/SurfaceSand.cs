using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceSand: ISurface {
    protected GameObject objectToControl;

    public SurfaceSand(GameObject objectToControl) {
        if (objectToControl.GetComponent<Rigidbody2D>() == null) {
            throw new System.Exception("Object must have a Rigidbody2D Component!");
        }

        if (objectToControl.GetComponent<Transform>() == null) {
            throw new System.Exception("Object must have a Transform Component!");
        }

        if (objectToControl.GetComponent<Level>() == null) {
            throw new System.Exception("Object must have a Level Component!");
        }

        this.objectToControl = objectToControl;
    }

    public void Jump() {
        if (objectToControl.GetComponent<Rigidbody2D>().velocity.y == 0.0f) {
            objectToControl.GetComponent<Rigidbody2D>().AddForce(objectToControl.GetComponent<Transform>().up * Config.jumpHeightPowerInSand);
        }
    }

    public void MoveUp() {

    }

    public void MoveDown() {

    }

    public void MoveLeft() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x - Config.speedInSand, objectToControl.GetComponent<Transform>().position.y);
    }

    public void MoveRight() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x + Config.speedInSand, objectToControl.GetComponent<Transform>().position.y);
    }

    public void OnEnter(Collision2D collision) {
        if (collision.relativeVelocity.magnitude >= 11.0f) {
            objectToControl.GetComponent<Level>().GameOver("Killed by fall!");
        }
    }

    public void OnExit(Collision2D collision) {

    }

    public void OnEnterTrigger(Collider2D other) {
        
    }

    public void OnExitTrigger(Collider2D other) {

    }
}
