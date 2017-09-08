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

public class Timer : MonoBehaviour {
    protected float time;
    protected bool timerOn;
    public bool showClock;
    public GameObject clock;

    private void Start () {
        startTimer();

        if (showClock) {
            clock.SetActive(true);
        }
        else {
            clock.SetActive(false);
        }
	}

    private void Update () {
		if (timerOn) {
            time += Time.deltaTime;
        }

        if (showClock) {
            updateClockDisplay();
        }
    }

    public float getSeconds() {
        return time;
    }

    public void stopTimer() {
        Time.timeScale = 0;
        timerOn = false;
    }

    public void startTimer() {
        Time.timeScale = 1.0f;
        timerOn = true;
    }

    public void setTimer(float t) {
        time = t;
    }

    public static string clockify(float time) {
        double totalMinutes = Math.Floor(time / 60);
        double totalSeconds = time % 60;

        return totalMinutes.ToString("00") + ":" + totalSeconds.ToString("00.0");
    }

    protected void updateClockDisplay() {
        Text label = clock.GetComponent<Text>();
        float totalSeconds = GetComponent<Timer>().getSeconds();
        label.text = Timer.clockify(totalSeconds);
    }
}
