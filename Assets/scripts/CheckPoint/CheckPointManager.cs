using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointManager : MonoBehaviour {
    public bool spawningEnabled = true;
    public int level;

    // This is the dropdown GameObject we use to show the different
    // checkpoints someone can spawn to manually.  
    public GameObject dropdown;

    // We use this property so we know if someone loaded a checkpoint.  If
    // they did, we disable the time as time no longer plays a role.
    public bool didLoadCheckpoint = false;

    private void Start() {
        populateDropDown();
    }

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
            spawnToLastCheckpoint();
        }
    }

    public void spawnToLastCheckpoint() {
        if (ApplicationModel.killMessage != "") {
            GetComponent<Jumbotron>().add(ApplicationModel.killMessage);
            ApplicationModel.killMessage = "";
        }

        CheckPointType checkpoint = ApplicationModel.getLastSavedCheckpoint(level);

        if (checkpoint != null) {
            // Spawn player last checkpoint reached
            GetComponent<Timer>().setTimer(checkpoint.time);
            GetComponent<Jumbotron>().add("Spawning to last checkpoint!");

            spawn(checkpoint);
        }
    }

    public void populateDropDown() {
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("SpawnPoint");        

        for (int i = 0; i < checkpoints.Length; i++) {
            //dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData(checkpoints[i].name));
            dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData((i+1).ToString()));
        }

        //dropdown.GetComponent<Dropdown>().options.Sort((x, y) => x.text.CompareTo(y.text));
    }

    public void onCheckpointDropDownSelect() {
        int selectedIndex = dropdown.GetComponent<Dropdown>().value;
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        didLoadCheckpoint = true;

        for (int i = 0; i < checkpoints.Length; i++) {
            if (checkpoints[i].name == "CheckPoint"+ (selectedIndex+1).ToString()) {
                spawn(
                    new CheckPointType(
                        checkpoints[i].gameObject.transform.position.x, 
                        checkpoints[i].gameObject.transform.position.y, 
                        0.0f
                    )
                );
            }
        }
    }

    public void spawn(CheckPointType checkpoint) {
        transform.position = new Vector2(
            checkpoint.x,
            checkpoint.y
        );
    }

    public void clearSavedCheckPoint() {
        ApplicationModel.setLastSavedCheckpoint(null, level);
    }
}
