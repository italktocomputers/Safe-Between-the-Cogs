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

public class SettingsScene : MonoBehaviour {
    public GameObject copyright;

    public GameObject clearStatsBtn;
    public GameObject clearStatsConfirmBtn;
    public GameObject clearStatsCancelBtn;
    public GameObject saveScoreToLBCheckbox;

    public GameObject qualityFastest;
    public GameObject qualityFast;
    public GameObject qualitySimple;
    public GameObject qualityGood;
    public GameObject qualityBeautiful;
    public GameObject qualityFantastic;

    public GameObject btnChecked;
    public GameObject btnUnChecked;

    private void Start () {
        Time.timeScale = 1.0f;

        if (ApplicationModel.getSaveScoreToLBSetting() == 1) {
            saveScoreToLBCheckbox.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        }
        else {
            saveScoreToLBCheckbox.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
        }

        if (ApplicationModel.getQuality() == "") {
            saveScoreToLBCheckbox.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        }

        resetQualityRadioBtns();

        switch (ApplicationModel.getQuality()) {
            case "Fastest":
                qualityFastest.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
                break;
            case "Fast":
                qualityFast.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
                break;
            case "Simple":
                qualitySimple.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
                break;
            case "Good":
                qualityGood.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
                break;
            case "Beautiful":
                qualityBeautiful.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
                break;
            case "Fantastic":
                qualityFantastic.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
                break;
        }

        copyright.GetComponent<Text>().text = ApplicationModel.getCopyrightString();
    }

    protected void resetQualityRadioBtns() {
        qualityFastest.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
        qualityFast.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
        qualitySimple.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
        qualityGood.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
        qualityBeautiful.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
        qualityFantastic.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
    }

    public void clearStatsBtnClick() {
        clearStatsBtn.SetActive(false);
        clearStatsConfirmBtn.SetActive(true);
        clearStatsCancelBtn.SetActive(true);
    }

    public void clearStatsConfirmBtnClick() {
        ApplicationModel.lastTime = 0;

        ApplicationModel.deleteLastTime("1");
        ApplicationModel.deleteBestTime("1");

        //FacebookHelper.deleteMyScore (null);

        clearStatsBtn.SetActive(true);
        clearStatsConfirmBtn.SetActive(false);
        clearStatsCancelBtn.SetActive(false);
    }

    public void clearStatsCancelBtnClick() {
        clearStatsBtn.SetActive(true);
        clearStatsConfirmBtn.SetActive(false);
        clearStatsCancelBtn.SetActive(false);
    }

    public void qualityBtnClickFastest() {
        resetQualityRadioBtns();
        qualityFastest.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        ApplicationModel.setQuality("Fastest");
    }

    public void qualityBtnClickFast() {
        resetQualityRadioBtns();
        qualityFast.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        ApplicationModel.setQuality("Fast");
    }

    public void qualityBtnClickSimple() {
        resetQualityRadioBtns();
        qualitySimple.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        ApplicationModel.setQuality("Simple");
    }

    public void qualityBtnClickGood() {
        resetQualityRadioBtns();
        qualityGood.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        ApplicationModel.setQuality("Good");
    }

    public void qualityBtnClickBeautiful() {
        resetQualityRadioBtns();
        qualityBeautiful.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        ApplicationModel.setQuality("Beautiful");
    }

    public void qualityBtnClickFantastic() {
        resetQualityRadioBtns();
        qualityFantastic.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        ApplicationModel.setQuality("Fantastic");
    }

    public void saveScoreToLBButtonClick() {
        int choice;

        if (ApplicationModel.getSaveScoreToLBSetting() == 0) {
            choice = 1;
            saveScoreToLBCheckbox.GetComponent<Image>().sprite = btnChecked.GetComponent<Image>().sprite;
        }
        else {
            choice = 0;
            saveScoreToLBCheckbox.GetComponent<Image>().sprite = btnUnChecked.GetComponent<Image>().sprite;
        }

        ApplicationModel.setSaveScoreToLBSetting(choice);
    }

    public void onBackButtonClick() {
        SceneManager.LoadScene("Welcome");
    }
}
