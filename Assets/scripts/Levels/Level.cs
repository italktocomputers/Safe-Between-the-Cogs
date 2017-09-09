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
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

abstract public class Level : MonoBehaviour {
    public int sceneIndex;
    public GameObject canvasLevelCompleted;
    public GameObject pauseWindow;
    public GameObject thisTimeGameObj;
    public GameObject lastTimeGameObj;
    public GameObject bestTimeGameObj;
    public GameObject congratsMsg;
    public GameObject starsCollectedObj;
    public GameObject starsTotalObj;

    abstract public void init();
    abstract public void disableALLGameObjects();
    abstract public string getLevelName();

    private void Start() {
        CheckpointManager checkpointManager = GetComponent<CheckpointManager>();

        GetComponent<Timer>().startTimer();

        Config.init();

        if (checkpointManager.spawningEnabled == true) {
            disableALLGameObjects();
        }

        init();
    }

    public void levelComplete() {
        GetComponent<Timer>().stopTimer();
        canvasLevelCompleted.SetActive(true);

        LevelCompleteUI ui = canvasLevelCompleted.GetComponent<LevelCompleteUI>();

        string name = getLevelName();

        float thisTime = GetComponent<Timer>().getSeconds();
        float lastTime = ApplicationModel.getLastTime(name);
        float bestTime = ApplicationModel.getBestTime(name);

        ui.setThisTime(thisTime);
        ui.setLastTime(lastTime);
        ui.setBestTime(bestTime);
        ui.setStarsCollected(GetComponent<StarManager>().totalStarsCollected);
        ui.setTotalStars(GetComponent<StarManager>().totalStars);

        ApplicationModel.saveLastTime(thisTime, name);
        
        if (bestTime == 0 || thisTime < bestTime) {
            // This is the new best time!
            ApplicationModel.saveBestTime(thisTime, name);
            //bestTimeLabel.text = Timer.clockify(thisTime);
            //congratsMsg.SetActive(true);

            if (ApplicationModel.getSaveScoreToLBSetting() == 1) {
                //FacebookHelper.SaveScore(thisTime, null);
            }
        }
        else {
            //bestTimeLabel.text = Timer.clockify(bestTime);
        }

        clearLevelData();
    }

    public void pause() {
        ApplicationModel.isPaused = true;
        GetComponent<Timer>().stopTimer();
        pauseWindow.SetActive(true);
    }

    public void unpause() {
        GetComponent<Timer>().startTimer();
        pauseWindow.SetActive(false);
        ApplicationModel.isPaused = false;
    }

    public void togglePause() {
        if (ApplicationModel.isPaused) {
            unpause();
        }
        else {
            pause();
        }
    }

    public void exitGame() {
        SceneManager.LoadScene(0);
    }

    public void resetGame() {
        SceneManager.LoadScene(0);
        clearLevelData();
    }

    public void clearLevelData() {
        GetComponent<CheckpointManager>().clearSavedCheckpoint();
        GetComponent<StarManager>().clearSavedStars();
    }

    public void GameOver(string message = "") {
        Time.timeScale = 0;
        ApplicationModel.lastPosition = transform.position;

        // Remember this is NOT their first attempt.  We do this
        // so when we reload, we can load the nearest checkpoint.
        ApplicationModel.firstTry = false;

        // If there is a kill message, save it!
        if (message != "") {
            ApplicationModel.killMessage = message;
        }
        
        // Reset Scene
        SceneManager.LoadScene(GetComponent<Level>().sceneIndex);
    }

    public static void resetLevelSettings() {
        ApplicationModel.lastTime = 0.0f;
        ApplicationModel.firstTry = true;
        ApplicationModel.isPaused = false;
    }
}
