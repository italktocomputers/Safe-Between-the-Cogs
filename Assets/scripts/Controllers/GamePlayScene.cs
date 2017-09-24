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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayScene : MonoBehaviour {
    public GameObject pauseWindow;

    private void Start() {
        CheckPointManager checkpointManager = GetComponent<CheckPointManager>();
        GetComponent<Timer>().startTimer();
        Config.init();

        if (checkpointManager.spawningEnabled == true) {
            GetComponent<ILevel>().disableAllGameObjects();
        }

        GetComponent<ILevel>().init();
    }

    public void levelComplete() {
        GetComponent<Timer>().stopTimer();

        GameStats stats = new GameStats(
            GetComponent<ILevel>().getLevelName(),
            GetComponent<Timer>().getSeconds(), 
            GetComponent<StarManager>().totalStarsCollected,
            GetComponent<StarManager>().totalStars
        );

        ApplicationModel.setThisGameStats(stats);
        ApplicationModel.saveLastTime(GetComponent<Timer>().getSeconds(), name);

        clearLevelData();

        SceneManager.LoadScene("GameOver");
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
        SceneManager.LoadScene("Welcome");
    }

    public void resetGame() {
        SceneManager.LoadScene("Welcome");
        clearLevelData();
    }

    public void clearLevelData() {
        GetComponent<CheckPointManager>().clearSavedCheckpoint();
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
        SceneManager.LoadScene(GetComponent<ILevel>().getLevelName());
    }

    public static void resetLevelSettings() {
        ApplicationModel.lastTime = 0.0f;
        ApplicationModel.firstTry = true;
        ApplicationModel.isPaused = false;
    }
}
