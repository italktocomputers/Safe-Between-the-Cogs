﻿/*
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
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaderboardScene : MonoBehaviour {
    public GameObject copyright;

    private void Start() {
        Time.timeScale = 1.0f;
        copyright.GetComponent<Text>().text = ApplicationModel.getCopyrightString();
        loadStats();
    }

    public void onBackButtonClick() {
        SceneManager.LoadScene("Welcome");
    }

    public void onPlayButtonClick() {
        SceneManager.LoadScene(ApplicationModel.selectedLevelName);
    }

    private void loadStats() {
        int i = 1;
        ILeaderboard leaderboard = ApplicationModel.getLeaderboard(ApplicationModel.selectedLevelIndex);
        List<KeyValuePair<string, float>> results = leaderboard.get();
        LeaderboardUI ui = GetComponent<LeaderboardUI>();

        foreach(KeyValuePair<string, float> record in results) {
            ui.updateLeaderboard(i++, record.Key, record.Value);
        }
    }
}
