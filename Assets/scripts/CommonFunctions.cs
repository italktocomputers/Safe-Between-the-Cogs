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
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CommonFunctions : MonoBehaviour {
    public void exitGame() {
        SceneManager.LoadScene(0);
    }

    public void AddDynamicBodyTypeToRigidBody(GameObject gameObject) {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void playHammerSound(GameObject objectToControl) {
        objectToControl.GetComponent<AudioSource>().clip = Config.audioHammer;
        objectToControl.GetComponent<AudioSource>().Play();
    }
}

