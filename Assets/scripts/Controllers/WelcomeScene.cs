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

public class WelcomeScene : MonoBehaviour {
    public GameObject copyright;

    private void Start () {
        Time.timeScale = 1.0f;

        if (ApplicationModel.isNotFirstTime() == 0) {
            // They are loading this game for the first time, so we will set some defaults.
            ApplicationModel.setSaveScoreToLBSetting(1);
            ApplicationModel.setIsNotFirstTime();
            ApplicationModel.setQuality("Good");
        }

        QualitySettings.SetQualityLevel(ApplicationModel.qualityStringToIndex(ApplicationModel.getQuality()));
        copyright.GetComponent<Text>().text = ApplicationModel.getCopyrightString();
    }

    public void onStartGameButtonClick() {
        SceneManager.LoadScene("Scene1");
    }

    public void onStartGameButton2Click() {
        SceneManager.LoadScene("Scene2");
    }

    public void onHowToPlayButtonClick() {
        SceneManager.LoadScene("HowToPlay");
    }

    public void onSettingsButtonClick() {
        SceneManager.LoadScene("Settings");
    }
}
