using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Leaderboard_Local : ILeaderboard {
    private int level;
    private Dictionary<string, float> leaderboard;

    public void init(int level) {
        this.level = level;
        string serialized = PlayerPrefs.GetString("Leaderboard_" + level.ToString());
        
        if (serialized != "") {
            leaderboard = deserialize(serialized);
        }
        else {
            leaderboard = new Dictionary<string, float>();
        }
    }

    public Dictionary<string, float> get() {
        return leaderboard;      
    }

    public bool add(string user, float score) {
        leaderboard.Add(user, score);
        return true;
    }

    public bool sync() {
        clean();
        PlayerPrefs.SetString("Leaderboard_" + level.ToString(), serialize(leaderboard));
        return true;
    }

    public bool flush() {
        PlayerPrefs.SetString("Leaderboard_" + level.ToString(), "");
        return true;
    }

    private string serialize(Dictionary<string, float> data) {
        int i = 1;
        string str = "";

        foreach (KeyValuePair<string, float> record in data) {
            if (i > 0)
                str += "|";

            str += record.Key + "," + record.Value.ToString();

            i++;
        }

        return str;
    }

    private Dictionary<string, float> deserialize(string data) {
        Dictionary<string, float> leaderboard = new Dictionary<string, float>();
        string[] records = data.Split('|');

        foreach (string record in records) {
            string[] KeyValue = record.Split(',');
            leaderboard.Add(KeyValue[0], float.Parse(KeyValue[1], CultureInfo.InvariantCulture.NumberFormat));
        }

        return leaderboard;
    }

    //
    // Delete any records after 24 since the leaderboard only shows that amount.
    //
    private void clean() {
        int i = 1;

        if (leaderboard.Count > 24) {
            foreach (KeyValuePair<string, float> record in leaderboard) {
                if (i > 24) {
                    leaderboard.Remove(record.Key);
                }

                i++;
            }
        }
    }
}