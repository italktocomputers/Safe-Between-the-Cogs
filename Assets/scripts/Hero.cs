using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour {
    public void sendAction(InputAction action) {
        // The InputManager will call this method when meaningful input is
        // received from the keyboard.  This Entity should decide what to 
        // do with the action.
        //
        // By default, we will always defer to the SurfaceManager as to
        // how the Hero should behave with said action on current surface.
        // HOWEVER, if need be, we can choose to ignore the surface and 
        // decide here or elsewhere how we are to behave with said action.
        GetComponent<SurfaceManager>().sendAction(action);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "LevelComplete") {
            GetComponent<Level>().levelComplete();
        }
        else if (other.gameObject.tag == "Gear") {
            GetComponent<Level>().GameOver();
        }
        else if (other.gameObject.tag == "Fork") {
            GetComponent<Level>().GameOver();
        }
        else if (other.gameObject.tag == "Hammer") {
            GetComponent<Level>().GameOver();
        }
        else if (other.gameObject.tag == "Net") {
            GetComponent<Level>().GameOver();
        }
        else if (other.gameObject.tag == "RedBlock") {
            GetComponent<Level>().GameOver();
        }
    }
}
