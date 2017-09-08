/*
 * Copyright (C) 2017 Andrew Schools
 * 
 * This program is free software: you can redistribute it and/or modify it under the terms 
 * of the GNU General Public License as published by the Free Software Foundation, either 
 * version 3 of the License, or (at your option) any later version.
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
 * See the GNU General Public License for more details.
 * You should have received a copy of the GNU General Public License along with this program. 
 * If not, see http://www.gnu.org/licenses/.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceRock: ISurface {
    protected GameObject objectToControl;

    public SurfaceRock(GameObject objectToControl) {
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
        setDefaults();

        if (objectToControl.GetComponent<Rigidbody2D>().velocity.y == 0.0f) {
            objectToControl.GetComponent<Rigidbody2D>().AddForce(objectToControl.GetComponent<Transform>().up * Config.jumpHeightPower);
        }
    }

    public void MoveUp() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x, objectToControl.GetComponent<Transform>().position.y + Config.speed);
    }

    public void MoveDown() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x, objectToControl.GetComponent<Transform>().position.y - Config.speed);
    }

    public void MoveLeft() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x - Config.speed, objectToControl.GetComponent<Transform>().position.y);
    }

    public void MoveRight() {
        objectToControl.GetComponent<Transform>().position = new Vector2(objectToControl.GetComponent<Transform>().position.x + Config.speed, objectToControl.GetComponent<Transform>().position.y);
    }

    public void OnEnter(Collision2D collision) {
        //Debug.Log(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude >= 8.0f) {
            objectToControl.GetComponent<Level>().GameOver("Killed by fall!");
        }
    }
    
    // Why we have this function:
    // If you are touching a sticky block and a brown block at the same time,
    // the StickySurface OnExit event has not yet fired, resulting in gravityScale
    // still being set to 100.  So before we jump from this surface, we need to
    // make sure gravityScale is set back to 1.
    public void setDefaults() {
        objectToControl.GetComponent<Rigidbody2D>().gravityScale = 1;
        objectToControl.GetComponent<Rigidbody2D>().drag = 0.5f;
    }

    public void OnExit(Collision2D collision) {

    }

    public void OnEnterTrigger(Collider2D other) {

    }

    public void OnExitTrigger(Collider2D other) {

    }
}
