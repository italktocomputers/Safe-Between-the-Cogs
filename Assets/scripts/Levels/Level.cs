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
    abstract public string getLevelName();

    private void Start() {
        GetComponent<Timer>().startTimer();

        Config.init();

        init();
    }

    public void levelComplete() {
        GetComponent<Timer>().stopTimer();

        string name = getLevelName();

        float thisTime = GetComponent<Timer>().getSeconds();
        float lastTime = ApplicationModel.getLastTime(name);
        float bestTime = ApplicationModel.getBestTime(name);

        Text thisTimeLabel = thisTimeGameObj.GetComponent<Text>();
        Text lastTimeLabel = lastTimeGameObj.GetComponent<Text>();
        Text bestTimeLabel = bestTimeGameObj.GetComponent<Text>();

        Text starsCollectedLabel = starsCollectedObj.GetComponent<Text>();
        Text starsTotalLabel = starsTotalObj.GetComponent<Text>();

        thisTimeLabel.text = Timer.clockify(thisTime);
        lastTimeLabel.text = Timer.clockify(lastTime);

        ApplicationModel.saveLastTime(thisTime, name);

        starsCollectedLabel.text = GetComponent<StarManager>().totalStarsCollected.ToString();
        starsTotalLabel.text = GetComponent<StarManager>().totalStars.ToString();

        if (bestTime == 0 || thisTime < bestTime) {
            // This is the new best time!
            ApplicationModel.saveBestTime(thisTime, name);
            bestTimeLabel.text = Timer.clockify(thisTime);
            congratsMsg.SetActive(true);

            if (ApplicationModel.getSaveScoreToLBSetting() == 1) {
                //FacebookHelper.SaveScore(thisTime, null);
            }
        }
        else {
            bestTimeLabel.text = Timer.clockify(bestTime);
        }

        clearLevelData();

        canvasLevelCompleted.SetActive(true);
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

    public void exitGame() {
        SceneManager.LoadScene(0);
    }

    public void resetGame() {
        SceneManager.LoadScene(0);
        clearLevelData();
    }

    public void clearLevelData() {
        GetComponent<CheckPointManager>().clearSavedCheckPoint();
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
