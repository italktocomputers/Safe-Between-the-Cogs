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
using System.Globalization;
using UnityEngine;

public class Leaderboard_Local : ILeaderboard {
    private int level;
    private List<KeyValuePair<string, float>> leaderboard;

    public void init(int level) {
        this.level = level;
        string serialized = PlayerPrefs.GetString("Leaderboard_" + level.ToString());
        
        if (serialized != "") {
            leaderboard = deserialize(serialized);
        }
        else {
            leaderboard = new List<KeyValuePair<string, float>>();
        }
    }

    public List<KeyValuePair<string, float>> get() {
        return leaderboard;      
    }

    public bool add(string user, float score) {
        leaderboard.Add(new KeyValuePair<string, float>(user, score));
        return true;
    }

    public bool sync() {
        sort();
        clean();
        PlayerPrefs.SetString("Leaderboard_" + level.ToString(), serialize(leaderboard));
        return true;
    }

    public bool flush() {
        PlayerPrefs.SetString("Leaderboard_" + level.ToString(), null);
        return true;
    }

    private string serialize(List<KeyValuePair<string, float>> data) {
        //return JsonUtility.ToJson(data);

        int i = 0;
        string str = "";

        foreach (KeyValuePair<string, float> record in data) {
            if (i > 0)
                str += "|";

            str += record.Key + "," + record.Value.ToString();

            i++;
        }

        return str;
    }

    private List<KeyValuePair<string, float>> deserialize(string data) {
        //return JsonUtility.FromJson<List<KeyValuePair<string, float>>>(data);

        List<KeyValuePair<string, float>> leaderboard = new List<KeyValuePair<string, float>>();
        string[] records = data.Split('|');

        foreach (string record in records) {
            string[] KeyValue = record.Split(',');
            leaderboard.Add(new KeyValuePair<string, float>(KeyValue[0], float.Parse(KeyValue[1], CultureInfo.InvariantCulture.NumberFormat)));
        }

        return leaderboard;
    }

    private void sort() {
        leaderboard.Sort(delegate (KeyValuePair<string, float> pair1, KeyValuePair<string, float> pair2) {
            return pair1.Value.CompareTo(pair2.Value);
        });
    }

    //
    // Delete any records after 24 since the leaderboard only shows that amount.
    //
    private void clean() {
        int i = 1;
        List<KeyValuePair<string, float>> newLeaderboard = new List<KeyValuePair<string, float>>();

        if (leaderboard.Count > 24) {
            foreach (KeyValuePair<string, float> record in leaderboard) {
                if (i++ > 24) {
                    break;
                }

                newLeaderboard.Add(record);
            }
        }

        leaderboard = newLeaderboard;
    }
}