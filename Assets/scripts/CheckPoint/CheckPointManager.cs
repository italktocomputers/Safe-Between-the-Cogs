using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour {
    public bool spawningEnabled = true;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "SpawnPoint") {
            ApplicationModel.setPosXOfSavedCheckpoint(GetComponent<Transform>().position.x);
            ApplicationModel.setPosYOfSavedCheckpoint(GetComponent<Transform>().position.y);
            ApplicationModel.setTimeOfSavedCheckpoint(GetComponent<Timer>().getSeconds());
            other.gameObject.GetComponent<CheckPoint>().e.Invoke();
            showCheckPointMsg();
        }
    }

    protected void showCheckPointMsg() {
        GetComponent<Jumbotron>().add("Checkpoint reached!");
    }

    protected void Awake() {
        if (spawningEnabled) {
            spawn();
        }
    }

    public void spawn() {
        if (ApplicationModel.killMessage != "") {
            GetComponent<Jumbotron>().add(ApplicationModel.killMessage);
            ApplicationModel.killMessage = "";
        }

        // Spawn player last checkpoint reached
        GetComponent<Timer>().setTimer(ApplicationModel.getTimeOfSavedCheckpoint());
        GetComponent<Jumbotron>().add("Spawning to last checkpoint!");

        if (ApplicationModel.getPosXOfSavedCheckpoint() != 0) {
            transform.position = new Vector2(
                ApplicationModel.getPosXOfSavedCheckpoint(),
                ApplicationModel.getPosYOfSavedCheckpoint()
            );
        }
    }

    public void clearSavedCheckPoint() {
        ApplicationModel.setTimeOfSavedCheckpoint(0.0f);
        ApplicationModel.setPosXOfSavedCheckpoint(0);
        ApplicationModel.setPosYOfSavedCheckpoint(0);
    }
}
