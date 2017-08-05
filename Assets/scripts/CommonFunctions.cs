using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CommonFunctions: MonoBehaviour {
    public void exitGame() {
        SceneManager.LoadScene(0);
    }

    public void AddDynamicBodyTypeToRigidBody(GameObject gameObject) {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void toggleRotationSpeed(GameObject go) {
        Rotate rotate = go.GetComponent<Rotate>();
        RotationToggleType rotationToggleType = go.GetComponent<RotationToggleType>();

        if (rotationToggleType.speed1 == rotate.speed) {
            rotate.speed = rotationToggleType.speed2;
        }
        else {
            rotate.speed = rotationToggleType.speed1;
        }
    }
}

