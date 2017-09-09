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
using UnityEngine.UI;
using System;

// When attached to a GameObject, a hint will be displayed when it collides with a
// GameObject that has the script 'Hint' attached to it. 
public class HintManager : MonoBehaviour {
    public GameObject UI_Hint;
    protected DateTime hintFirstShown;
    public string[] hints;

    private void Update() {
        DateTime now = DateTime.Now;
        TimeSpan lengthOfHint = (now - hintFirstShown).Duration();

        if (lengthOfHint.TotalSeconds >= 5) {
            UI_Hint.SetActive(false);
        }
    }

    protected void showHint(string msg) {
        hintFirstShown = DateTime.Now;
        UI_Hint.GetComponent<Text>().text = msg;
        UI_Hint.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Hint") {
            string hintMsg = hints[(other.GetComponent<Hint>().index)];
            showHint(hintMsg);

            // When colliding with a Hint, the Hint will be removed from the scene so not to display the
            // same hint over and over.
            other.gameObject.SetActive(false);
        }
    }
}
