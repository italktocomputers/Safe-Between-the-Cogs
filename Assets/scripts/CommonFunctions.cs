using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class CommonFunctions {
    public static void exitGame() {
        SceneManager.LoadScene(0);
    }
}

