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

public class StarManager : MonoBehaviour {
    public GameObject UI_StarsCollected;
    public GameObject UI_StarsTotal;
    public GameObject[] stars;
    public int sceneIndex;
    private int _totalStarsCollected = 0;
    private int _totalStars = 0;

    public int totalStarsCollected {
        get {
            return _totalStarsCollected;
        }
        set {
            _totalStarsCollected = value;
            UI_StarsCollected.GetComponent<Text>().text = value.ToString();
        }
    }

    public int totalStars {
        get {
            return _totalStars;
        }
        set {
            _totalStars = value;
            UI_StarsTotal.GetComponent<Text>().text = value.ToString();
        }
    }

    private void Start() {
        int i = 1;
        int starsCollected = 0;
         
        // Only enable stars that have NOT been collected
        foreach (GameObject star in stars) {
            if (ApplicationModel.getStarCollected(sceneIndex, i++) == 0) {
                star.SetActive(true);
            }
            else {
                star.SetActive(false);
                starsCollected++;
            }
        }

        totalStarsCollected = starsCollected;
        totalStars = stars.Length;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Star") {
            ApplicationModel.setStarCollected(sceneIndex, other.GetComponent<Star>().index);
            ++totalStarsCollected;
        }
    }

    public void clearSavedStars() {
        int i = 1;

        foreach (GameObject star in stars) {
            ApplicationModel.deleteStarCollected(sceneIndex, i++);
        }
    }
}
