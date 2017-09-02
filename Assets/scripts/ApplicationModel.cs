using UnityEngine;
using System;
using System.Collections;
using System.Globalization;

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
        return "Copyright 2017, Andrew Schools.  All rights reserved.  v1.0-alpha";
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

    static public CheckpointType getLastSavedCheckpoint(int level) {
        String data = PlayerPrefs.GetString("LastSavedCheckpoint_" + level.ToString());
        String[] parts = data.Split(',');

        if (parts.Length != 3) {
            return null;
        }
        else {
            float x = float.Parse(parts[0], CultureInfo.InvariantCulture.NumberFormat);
            float y = float.Parse(parts[1], CultureInfo.InvariantCulture.NumberFormat);
            float time = float.Parse(parts[2], CultureInfo.InvariantCulture.NumberFormat);

            return new CheckpointType(x, y, time);
        }
    }

    static public void setLastSavedCheckpoint(CheckpointType checkpoint, int level) {
        if (checkpoint == null) {
            PlayerPrefs.SetString("LastSavedCheckpoint_" + level.ToString(), null);
        }
        else {
            PlayerPrefs.SetString("LastSavedCheckpoint_" + level.ToString(), checkpoint.ToString());
        }
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