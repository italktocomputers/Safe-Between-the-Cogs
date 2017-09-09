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
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) == true) {
            GetComponent<Level>().togglePause();
        }

        if (Input.GetKeyDown(KeyCode.Z) == true) {
            Camera.main.orthographicSize = 6;
        }
        else if (Input.GetKeyUp(KeyCode.Z) == true) {
            Camera.main.orthographicSize = 2;
        }
    }
}
