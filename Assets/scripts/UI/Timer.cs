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

    public static string clockify(float totalSeconds) {
        float totalMinutes = totalSeconds / 60;
        return String.Format("{0:F0}:{1:F1}", (int)totalMinutes, totalSeconds % 60);
    }

    protected void updateClockDisplay() {
        Text label = clock.GetComponent<Text>();
        float totalSeconds = GetComponent<Timer>().getSeconds();
        label.text = Timer.clockify(totalSeconds);
    }
}
