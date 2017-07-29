using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceWater: ISurface {
    protected GameObject objectToControl;

    public SurfaceWater(GameObject objectToControl) {
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
        if (objectToControl.GetComponent<Rigidbody2D>().velocity.y <= 0.0f) {
            objectToControl.GetComponent<Rigidbody2D>().AddForce(objectToControl.GetComponent<Transform>().up * Config.jumpHeightPowerInWater);
        }
    }

    public void MoveUp() {
        
    }

    public void MoveDown() {
        
    }

    public void MoveLeft() {
        objectToControl.transform.position = new Vector2(objectToControl.transform.position.x - Config.swimSpeed, objectToControl.transform.position.y);
        playSwimSound();
    }

    public void MoveRight() {
        objectToControl.transform.position = new Vector2(objectToControl.transform.position.x + Config.swimSpeed, objectToControl.transform.position.y);
        playSwimSound();
    }

    public void OnEnter(Collision2D collision) {

    }

    public void OnExit(Collision2D collision) {

    }

    public void OnEnterTrigger(Collider2D other) {
        if (Mathf.Abs(objectToControl.GetComponent<Rigidbody2D>().velocity.y) >= 15.0f) {
            objectToControl.GetComponent<Level>().GameOver("Killed by fall!");
        }
        else {
            objectToControl.GetComponent<AudioSource>().clip = Config.audioSplash;
            objectToControl.GetComponent<AudioSource>().Play();
        }
    }

    public void OnExitTrigger(Collider2D other) {
        
    }

    protected void playSwimSound() {
        if (objectToControl.GetComponent<AudioSource>().isPlaying == false) {
            objectToControl.GetComponent<AudioSource>().clip = Config.audioSwim;
            objectToControl.GetComponent<AudioSource>().Play();
        }
    }
}
