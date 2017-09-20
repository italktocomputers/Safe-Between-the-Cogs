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
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaderboardScene : MonoBehaviour {
    public GameObject copyright;
    public GameObject LeaderboardName;

    public GameObject Name1;
    public GameObject Name2;
    public GameObject Name3;
    public GameObject Name4;
    public GameObject Name5;
    public GameObject Name6;
    public GameObject Name7;
    public GameObject Name8;
    public GameObject Name9;
    public GameObject Name10;
    public GameObject Name11;
    public GameObject Name12;
    public GameObject Name13;
    public GameObject Name14;
    public GameObject Name15;
    public GameObject Name16;
    public GameObject Name17;
    public GameObject Name18;
    public GameObject Name19;
    public GameObject Name20;
    public GameObject Name21;
    public GameObject Name22;
    public GameObject Name23;
    public GameObject Name24;

    public GameObject Score1;
    public GameObject Score2;
    public GameObject Score3;
    public GameObject Score4;
    public GameObject Score5;
    public GameObject Score6;
    public GameObject Score7;
    public GameObject Score8;
    public GameObject Score9;
    public GameObject Score10;
    public GameObject Score11;
    public GameObject Score12;
    public GameObject Score13;
    public GameObject Score14;
    public GameObject Score15;
    public GameObject Score16;
    public GameObject Score17;
    public GameObject Score18;
    public GameObject Score19;
    public GameObject Score20;
    public GameObject Score21;
    public GameObject Score22;
    public GameObject Score23;
    public GameObject Score24;

    private GameObject[,] leaderboard = new GameObject[24, 2];

    private void Start() {
        Time.timeScale = 1.0f;
        copyright.GetComponent<Text>().text = ApplicationModel.getCopyrightString();

        leaderboard[0, 0] = Name1;
        leaderboard[0, 1] = Score1;

        leaderboard[1, 0] = Name2;
        leaderboard[1, 1] = Score2;

        leaderboard[2, 0] = Name3;
        leaderboard[2, 1] = Score3;

        leaderboard[3, 0] = Name4;
        leaderboard[3, 1] = Score4;

        leaderboard[4, 0] = Name5;
        leaderboard[4, 1] = Score5;

        leaderboard[5, 0] = Name6;
        leaderboard[5, 1] = Score6;

        leaderboard[6, 0] = Name7;
        leaderboard[6, 1] = Score7;

        leaderboard[7, 0] = Name8;
        leaderboard[7, 1] = Score8;

        leaderboard[8, 0] = Name9;
        leaderboard[8, 1] = Score9;

        leaderboard[9, 0] = Name10;
        leaderboard[9, 1] = Score10;

        leaderboard[10, 0] = Name11;
        leaderboard[10, 1] = Score11;

        leaderboard[11, 0] = Name12;
        leaderboard[11, 1] = Score12;

        leaderboard[12, 0] = Name13;
        leaderboard[12, 1] = Score13;

        leaderboard[13, 0] = Name14;
        leaderboard[13, 1] = Score14;

        leaderboard[14, 0] = Name15;
        leaderboard[14, 1] = Score15;

        leaderboard[15, 0] = Name16;
        leaderboard[15, 1] = Score16;

        leaderboard[16, 0] = Name17;
        leaderboard[16, 1] = Score17;

        leaderboard[17, 0] = Name18;
        leaderboard[17, 1] = Score18;

        leaderboard[18, 0] = Name19;
        leaderboard[18, 1] = Score19;

        leaderboard[19, 0] = Name20;
        leaderboard[19, 1] = Score20;

        leaderboard[20, 0] = Name21;
        leaderboard[20, 1] = Score21;

        leaderboard[21, 0] = Name22;
        leaderboard[21, 1] = Score22;

        leaderboard[22, 0] = Name23;
        leaderboard[22, 1] = Score23;

        leaderboard[23, 0] = Name24;
        leaderboard[23, 1] = Score24;

        loadStats();
    }

    public void onBackButtonClick() {
        SceneManager.LoadScene("Welcome");
    }

    public void onPlayButtonClick() {
        SceneManager.LoadScene(ApplicationModel.selectedLevelName);
    }

    public void updateLeaderboard(int index, string name, float score) {
        leaderboard[index - 1, 0].GetComponent<Text>().text = name;
        leaderboard[index - 1, 1].GetComponent<Text>().text = score.ToString();
    }

    private void loadStats() {
        int i = 1;
        ILeaderboard leaderboard = ApplicationModel.getLeaderboard(ApplicationModel.selectedLevelIndex);
        List<KeyValuePair<string, float>> results = leaderboard.get();

        foreach(KeyValuePair<string, float> record in results) {
            updateLeaderboard(i++, record.Key, record.Value);
        }
    }
}
