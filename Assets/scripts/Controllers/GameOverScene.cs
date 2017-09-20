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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour {
    public GameObject copyright;

    public GameObject thisTimeM1;
    public GameObject thisTimeM2;
    public GameObject thisTimeS1;
    public GameObject thisTimeS2;
    public GameObject thisTimeMS;

    public GameObject lastTimeM1;
    public GameObject lastTimeM2;
    public GameObject lastTimeS1;
    public GameObject lastTimeS2;
    public GameObject lastTimeMS;

    public GameObject bestTimeM1;
    public GameObject bestTimeM2;
    public GameObject bestTimeS1;
    public GameObject bestTimeS2;
    public GameObject bestTimeMS;

    public GameObject starsCollected1;
    public GameObject starsCollected2;

    public GameObject totalStars1;
    public GameObject totalStars2;

    private Texture2D t0_l;
    private Texture2D t1_l;
    private Texture2D t2_l;
    private Texture2D t3_l;
    private Texture2D t4_l;
    private Texture2D t5_l;
    private Texture2D t6_l;
    private Texture2D t7_l;
    private Texture2D t8_l;
    private Texture2D t9_l;
    private Texture2D tPeriod_l;
    private Texture2D tColon_l;

    private Texture2D t0_s;
    private Texture2D t1_s;
    private Texture2D t2_s;
    private Texture2D t3_s;
    private Texture2D t4_s;
    private Texture2D t5_s;
    private Texture2D t6_s;
    private Texture2D t7_s;
    private Texture2D t8_s;
    private Texture2D t9_s;
    private Texture2D tPeriod_s;
    private Texture2D tColon_s;

    private Dictionary<char, Texture2D> map_l = new Dictionary<char, Texture2D>();
    private Dictionary<char, Texture2D> map_s = new Dictionary<char, Texture2D>();

    private void Start() {
        Time.timeScale = 1.0f;
        copyright.GetComponent<Text>().text = ApplicationModel.getCopyrightString();

        t0_l = new Texture2D(138, 155);
        t0_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_0.png"));

        t1_l = new Texture2D(88, 153);
        t1_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_1.png"));

        t2_l = new Texture2D(119, 154);
        t2_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_2.png"));

        t3_l = new Texture2D(122, 161);
        t3_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_3.png"));

        t4_l = new Texture2D(126, 170);
        t4_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_4.png"));

        t5_l = new Texture2D(117, 156);
        t5_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_5.png"));

        t6_l = new Texture2D(125, 155);
        t6_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_6.png"));

        t7_l = new Texture2D(119, 161);
        t7_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_7.png"));

        t8_l = new Texture2D(129, 157);
        t8_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_8.png"));

        t9_l = new Texture2D(125, 154);
        t9_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_9.png"));

        tPeriod_l = new Texture2D(125, 154);
        tPeriod_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Period_l.png"));

        tColon_l = new Texture2D(125, 154);
        tColon_l.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Colon_l.png"));

        t0_s = new Texture2D(61, 66);
        t0_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_0_s.png"));

        t1_s = new Texture2D(47, 65);
        t1_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_1_s.png"));

        t2_s = new Texture2D(56, 65);
        t2_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_2_s.png"));

        t3_s = new Texture2D(57, 67);
        t3_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_3_s.png"));

        t4_s = new Texture2D(58, 69);
        t4_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_4_s.png"));

        t5_s = new Texture2D(55, 66);
        t5_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_5_s.png"));

        t6_s = new Texture2D(58, 65);
        t6_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_6_s.png"));

        t7_s = new Texture2D(56, 67);
        t7_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_7_s.png"));

        t8_s = new Texture2D(58, 66);
        t8_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_8_s.png"));

        t9_s = new Texture2D(58, 65);
        t9_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Number_9_s.png"));

        tPeriod_s = new Texture2D(125, 154);
        tPeriod_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Period_s.png"));

        tColon_s = new Texture2D(125, 154);
        tColon_s.LoadImage(System.IO.File.ReadAllBytes("./Assets/images/Colon_s.png"));

        map_l.Add('0', t0_l);
        map_l.Add('1', t1_l);
        map_l.Add('2', t2_l);
        map_l.Add('3', t3_l);
        map_l.Add('4', t4_l);
        map_l.Add('5', t5_l);
        map_l.Add('6', t6_l);
        map_l.Add('7', t7_l);
        map_l.Add('8', t8_l);
        map_l.Add('9', t9_l);
        map_l.Add('.', tPeriod_l);
        map_l.Add(':', tColon_l);

        map_s.Add('0', t0_s);
        map_s.Add('1', t1_s);
        map_s.Add('2', t2_s);
        map_s.Add('3', t3_s);
        map_s.Add('4', t4_s);
        map_s.Add('5', t5_s);
        map_s.Add('6', t6_s);
        map_s.Add('7', t7_s);
        map_s.Add('8', t8_s);
        map_s.Add('9', t9_s);
        map_s.Add('.', tPeriod_s);
        map_s.Add(':', tColon_s);

        GameStats stats = ApplicationModel.getThisGameStats();

        float lastTime = ApplicationModel.getLastTime(ApplicationModel.selectedLevelName);
        float bestTime = ApplicationModel.getBestTime(ApplicationModel.selectedLevelName);

        // Update UI
        setThisTime(stats.time);
        setLastTime(lastTime);
        setBestTime(bestTime);
        setStarsCollected(stats.starsCollected);
        setTotalStars(stats.totalStarsInLevel);

        // Save this new best time
        if (bestTime == 0 || stats.time < bestTime) {
            ApplicationModel.saveBestTime(stats.time, name);
        }

        ApplicationModel.saveLastTime(stats.time, ApplicationModel.selectedLevelName);
    }

    public void setThisTime(float time) {
        Sprite[] sprites = numberToSprites(Timer.clockify(time), map_l);
        this.thisTimeM1.GetComponent<Image>().sprite = sprites[0];
        this.thisTimeM2.GetComponent<Image>().sprite = sprites[1];
        this.thisTimeS1.GetComponent<Image>().sprite = sprites[2];
        this.thisTimeS2.GetComponent<Image>().sprite = sprites[3];
        this.thisTimeMS.GetComponent<Image>().sprite = sprites[4];
    }

    public void setLastTime(float time) {
        Sprite[] sprites = numberToSprites(Timer.clockify(time), map_s);
        this.lastTimeM1.GetComponent<Image>().sprite = sprites[0];
        this.lastTimeM2.GetComponent<Image>().sprite = sprites[1];
        this.lastTimeS1.GetComponent<Image>().sprite = sprites[2];
        this.lastTimeS2.GetComponent<Image>().sprite = sprites[3];
        this.lastTimeMS.GetComponent<Image>().sprite = sprites[4];
    }

    public void setBestTime(float time) {
        Sprite[] sprites = numberToSprites(Timer.clockify(time), map_s);
        this.bestTimeM1.GetComponent<Image>().sprite = sprites[0];
        this.bestTimeM2.GetComponent<Image>().sprite = sprites[1];
        this.bestTimeS1.GetComponent<Image>().sprite = sprites[2];
        this.bestTimeS2.GetComponent<Image>().sprite = sprites[3];
        this.bestTimeMS.GetComponent<Image>().sprite = sprites[4];
    }

    public void setStarsCollected(int stars) {
        Sprite[] sprites = numberToSprites(stars.ToString(), map_l);

        if (stars > 9) {
            this.starsCollected1.GetComponent<Image>().sprite = sprites[0];
            this.starsCollected2.GetComponent<Image>().sprite = sprites[1];
        }
        else {
            this.starsCollected1.GetComponent<Image>().sprite = new Sprite();
            this.starsCollected1.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            this.starsCollected2.GetComponent<Image>().sprite = sprites[0];
        }
    }

    public void setTotalStars(int stars) {
        Sprite[] sprites = numberToSprites(stars.ToString(), map_l);

        if (stars > 9) {
            this.totalStars1.GetComponent<Image>().sprite = sprites[0];
            this.totalStars2.GetComponent<Image>().sprite = sprites[1];
        }
        else {
            this.totalStars1.GetComponent<Image>().sprite = new Sprite();
            this.totalStars1.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            this.totalStars2.GetComponent<Image>().sprite = sprites[0];
        }
    }

    private Sprite[] numberToSprites(string n, Dictionary<char, Texture2D> map) {
        int i = 0;
        Sprite[] sprites = new Sprite[5];
        char[] cArray = n.ToCharArray();

        foreach (char c in cArray) {
            if (c == '.' || c == ':') {
                continue;
            }

            if (i > 4) {
                break;
            }

            Texture2D t = map[c];
            sprites[i] = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0, 0));

            i++;
        }

        return sprites;
    }

    public void onForwardButtonClick() {
        GameStats stats = ApplicationModel.getThisGameStats();
        ILeaderboard leaderboard = ApplicationModel.getLeaderboard(ApplicationModel.selectedLevelIndex);

        List<KeyValuePair<string, float>> records = leaderboard.get();

        if (records.Count < 24) {
            SceneManager.LoadScene("Congrats");
        }
        else {
            int index = records.Count - 1;
            KeyValuePair<string, float> lastRecord = records[index];

            if (stats.time < lastRecord.Value) {
                SceneManager.LoadScene("Congrats");
            }
            else {
                SceneManager.LoadScene("Welcome");
            }
        }
    }
}
