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
