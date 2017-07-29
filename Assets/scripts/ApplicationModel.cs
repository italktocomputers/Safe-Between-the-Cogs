using UnityEngine;
using System;
using System.Collections;

public class ApplicationModel : MonoBehaviour {
    static public bool dev = false;
    static public Vector2 lastPosition;
    static public bool firstTry = true;
    static public bool firstFall = true;
    static public string killMessage = "";
    static public float lastTime = 0.0f;
    static public bool isPaused = false;

    static public int isNotFirstTime() {
        return PlayerPrefs.GetInt("isNotFirstTime");
    }

    static public void setIsNotFirstTime() {
        PlayerPrefs.SetInt("isNotFirstTime", 1);
    }

    static public int qualityStringToIndex(string quality) {
        switch (quality) {
            case "Fastest":
                return 0;
            case "Fast":
                return 1;
            case "Simple":
                return 2;
            case "Good":
                return 3;
            case "Beautiful":
                return 4;
            case "Fantastic":
                return 5;
        }

        return 0;
    }

    static public string getCopyrightString() {
        return "Copyright 2017, Andrew Schools.  All rights reserved.  Build 06.02.2017.1";
    }

    static public string getQuality() {
        return PlayerPrefs.GetString("Quality");
    }

    static public void setQuality(string quality) {
        PlayerPrefs.SetString("Quality", quality);
    }

    static public void saveLastTime(float time, string levelName) {
        PlayerPrefs.SetFloat("lastTime_" + levelName, time);
    }

    static public float getLastTime(string levelName) {
        return PlayerPrefs.GetFloat("lastTime_" + levelName);
    }

    static public void deleteLastTime(string levelName) {
        PlayerPrefs.DeleteKey("lastTime_" + levelName);
    }

    static public void saveBestTime(float time, string levelName) {
        PlayerPrefs.SetFloat("bestTime_" + levelName, time);
    }

    static public float getBestTime(string levelName) {
        return PlayerPrefs.GetFloat("bestTime_" + levelName);
    }

    static public void deleteBestTime(string levelName) {
        PlayerPrefs.DeleteKey("bestTime_" + levelName);
    }

    static public int getSaveScoreToLBSetting() {
        return PlayerPrefs.GetInt("Setting_SaveScoreToLB");
    }

    static public void setSaveScoreToLBSetting(int choice) {
        PlayerPrefs.SetInt("Setting_SaveScoreToLB", choice);
    }

    static public float getPosXOfSavedCheckpoint() {
        return PlayerPrefs.GetFloat("PosXOfSavedCheckpoint");
    }

    static public float getPosYOfSavedCheckpoint() {
        return PlayerPrefs.GetFloat("PosYOfSavedCheckpoint");
    }

    static public void setPosXOfSavedCheckpoint(float x) {
        PlayerPrefs.SetFloat("PosXOfSavedCheckpoint", x);
    }

    static public void setPosYOfSavedCheckpoint(float y) {
        PlayerPrefs.SetFloat("PosYOfSavedCheckpoint", y);
    }

    static public float getTimeOfSavedCheckpoint() {
        return PlayerPrefs.GetFloat("TimeOfSavedCheckpoint");
    }

    static public void setTimeOfSavedCheckpoint(float time) {
        PlayerPrefs.SetFloat("TimeOfSavedCheckpoint", time);
    }

    static public int getStarCollected(int level, int num) {
        return PlayerPrefs.GetInt("StarCollected_" + level.ToString() + "_" + num.ToString());
    }

    static public void setStarCollected(int level, int num) {
        PlayerPrefs.SetInt("StarCollected_" + level.ToString() + "_" + num.ToString(), 1);
    }

    static public void deleteStarCollected(int level, int num) {
        PlayerPrefs.DeleteKey("StarCollected_" + level.ToString() + "_" + num.ToString());
    }
}