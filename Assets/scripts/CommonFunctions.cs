using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CommonFunctions : MonoBehaviour {
    public void exitGame() {
        SceneManager.LoadScene(0);
    }

    public void AddDynamicBodyTypeToRigidBody(GameObject gameObject) {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void playHammerSound(GameObject objectToControl) {
        objectToControl.GetComponent<AudioSource>().clip = Config.audioHammer;
        objectToControl.GetComponent<AudioSource>().Play();
    }
}

