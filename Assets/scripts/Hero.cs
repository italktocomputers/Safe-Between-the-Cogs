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
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour {
    public void sendAction(InputAction action) {
        // The InputManager will call this method when meaningful input is
        // received from the keyboard.  This Entity should decide what to 
        // do with the action.
        //
        // By default, we will always defer to the SurfaceManager as to
        // how the Hero should behave with said action on current surface.
        // HOWEVER, if need be, we can choose to ignore the surface and 
        // decide here or elsewhere how we are to behave with said action.
        GetComponent<SurfaceManager>().sendAction(action);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "LevelComplete") {
            GetComponent<GamePlayScene>().levelComplete();
        }
        else if (other.gameObject.tag == "Gear") {
            GetComponent<GamePlayScene>().GameOver();
        }
        else if (other.gameObject.tag == "Fork") {
            GetComponent<GamePlayScene>().GameOver();
        }
        else if (other.gameObject.tag == "Hammer") {
            GetComponent<GamePlayScene>().GameOver();
        }
        else if (other.gameObject.tag == "Net") {
            GetComponent<GamePlayScene>().GameOver();
        }
        else if (other.gameObject.tag == "RedBlock") {
            GetComponent<GamePlayScene>().GameOver();
        }
    }
}
