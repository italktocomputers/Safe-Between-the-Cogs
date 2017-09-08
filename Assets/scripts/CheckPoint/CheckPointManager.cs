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

public class CheckpointManager : MonoBehaviour {
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
        if (other.gameObject.tag == "Checkpoint") {
            CheckpointType checkpoint = new CheckpointType(
                other.gameObject.GetComponent<Transform>().position.x,
                other.gameObject.GetComponent<Transform>().position.y,
                GetComponent<Timer>().getSeconds()
            );

            ApplicationModel.setLastSavedCheckpoint(checkpoint, level);
            other.gameObject.GetComponent<Checkpoint>().e.Invoke();
            showCheckpointMsg();
        }
    }

    protected void showCheckpointMsg() {
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

        CheckpointType checkpoint = ApplicationModel.getLastSavedCheckpoint(level);

        if (checkpoint != null) {
            // Spawn player last checkpoint reached
            GetComponent<Timer>().setTimer(checkpoint.time);
            GetComponent<Jumbotron>().add("Loading last checkpoint!");

            spawn(checkpoint);
        }
    }

    public void populateDropDown() {
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");        

        for (int i = 0; i < checkpoints.Length; i++) {
            //dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData(checkpoints[i].name));
            dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData((i+1).ToString()));
        }

        //dropdown.GetComponent<Dropdown>().options.Sort((x, y) => x.text.CompareTo(y.text));
    }

    public void onCheckpointDropDownSelect() {
        int selectedIndex = dropdown.GetComponent<Dropdown>().value;
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");

        didLoadCheckpoint = true;

        for (int i = 0; i < checkpoints.Length; i++) {
            if (checkpoints[i].name == "Checkpoint"+ (selectedIndex+1).ToString()) {
                // Save choice and load scene
                ApplicationModel.setLastSavedCheckpoint(
                    new CheckpointType(
                        checkpoints[i].gameObject.transform.position.x, 
                        checkpoints[i].gameObject.transform.position.y, 
                        0.0f
                    ),
                    level
                );

                SceneManager.LoadScene(GetComponent<Level>().sceneIndex);
            }
        }
    }

    public void spawn(CheckpointType checkpoint) {
        transform.position = new Vector2(
            checkpoint.x,
            checkpoint.y
        );
    }

    public void clearSavedCheckpoint() {
        ApplicationModel.setLastSavedCheckpoint(null, level);
    }
}
