using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour {
    public bool spawningEnabled = true;
    public int level;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "SpawnPoint") {
            CheckPointType checkpoint = new CheckPointType(
                other.gameObject.GetComponent<Transform>().position.x,
                other.gameObject.GetComponent<Transform>().position.y,
                GetComponent<Timer>().getSeconds()
            );

            ApplicationModel.setLastSavedCheckpoint(checkpoint, level);
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


        CheckPointType checkpoint = ApplicationModel.getLastSavedCheckpoint(level);

        if (checkpoint != null) {
            transform.position = new Vector2(
                checkpoint.x,
                checkpoint.y
            );

            // Spawn player last checkpoint reached
            GetComponent<Timer>().setTimer(checkpoint.time);
            GetComponent<Jumbotron>().add("Spawning to last checkpoint!");
        }
    }

    public void clearSavedCheckPoint() {
        ApplicationModel.setLastSavedCheckpoint(null, level);
    }
}
