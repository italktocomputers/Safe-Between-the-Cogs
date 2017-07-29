using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    protected Hero heroScript;

    private void Start() {
        heroScript = GetComponent<Hero>();
    }

    // Our input is directly altering a Rigidbody so we are using a FixedUpdate
    private void FixedUpdate() {
        if (Input.GetAxis("Horizontal") > 0) {
            heroScript.sendAction(InputAction.WalkRight);
        }
        else if (Input.GetAxis("Horizontal") < 0) {
            heroScript.sendAction(InputAction.WalkLeft);
        }

        if (Input.GetAxis("Vertical") == 1) {
            heroScript.sendAction(InputAction.ClimbUp);
        }
        else if (Input.GetAxis("Vertical") == -1) {
            heroScript.sendAction(InputAction.ClimbDown);
        }

        if (Input.GetAxis("Jump") == 1) {
            heroScript.sendAction(InputAction.Jump);
        }

        if (Input.GetAxis("Cancel") == 1) {
            GetComponent<Level>().pause();
        }

        if (Input.GetKeyDown(KeyCode.Z) == true) {
            Camera.main.orthographicSize = 6;
        }
        else if (Input.GetKeyUp(KeyCode.Z) == true) {
            Camera.main.orthographicSize = 2;
        }
    }
}
