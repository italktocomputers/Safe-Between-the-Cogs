using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowToPlayScene : MonoBehaviour {
    public GameObject copyright;

    private void Start () {
        Time.timeScale = 1.0f;
        copyright.GetComponent<Text>().text = ApplicationModel.getCopyrightString();
    }

    public void onBackButtonClick() {
        SceneManager.LoadScene("Welcome");
    }
}
