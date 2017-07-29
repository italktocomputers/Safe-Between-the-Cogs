using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceSticky: ISurface {
    protected GameObject objectToControl;

    public SurfaceSticky(GameObject objectToControl) {
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
        objectToControl.GetComponent<Rigidbody2D>().gravityScale = 1;
        objectToControl.GetComponent<Rigidbody2D>().drag = 0;

        if (objectToControl.GetComponent<Rigidbody2D>().velocity.y == 0.0f) {
            objectToControl.GetComponent<Rigidbody2D>().AddForce(objectToControl.GetComponent<Transform>().up * Config.jumpHeightPowerOnSticky);
        }
    }

    public void MoveUp() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x, objectToControl.GetComponent<Transform>().position.y + Config.speedOnSticky);
    }

    public void MoveDown() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x, objectToControl.GetComponent<Transform>().position.y - Config.speedOnSticky);
    }

    public void MoveLeft() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x - Config.speedOnSticky, objectToControl.GetComponent<Transform>().position.y);
    }

    public void MoveRight() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x + Config.speedOnSticky, objectToControl.GetComponent<Transform>().position.y);
    }

    public void OnEnter(Collision2D collision) {
        objectToControl.GetComponent<Rigidbody2D>().gravityScale = 0;
        objectToControl.GetComponent<Rigidbody2D>().drag = 100;
    }

    public void OnExit(Collision2D collision) {
        objectToControl.GetComponent<Rigidbody2D>().gravityScale = 1;
        objectToControl.GetComponent<Rigidbody2D>().drag = 0;
    }

    public void OnEnterTrigger(Collider2D other) {

    }

    public void OnExitTrigger(Collider2D other) {

    }
}
