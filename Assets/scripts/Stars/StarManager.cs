using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour {
    public GameObject UI_StarsCollected;
    public GameObject UI_StarsTotal;
    public GameObject[] stars;
    public int sceneIndex;
    private int _totalStarsCollected = 0;
    private int _totalStars = 0;

    public int totalStarsCollected {
        get {
            return _totalStarsCollected;
        }
        set {
            _totalStarsCollected = value;
            UI_StarsCollected.GetComponent<Text>().text = value.ToString();
        }
    }

    public int totalStars {
        get {
            return _totalStars;
        }
        set {
            _totalStars = value;
            UI_StarsTotal.GetComponent<Text>().text = value.ToString();
        }
    }

    private void Start() {
        int i = 1;
        int starsCollected = 0;
         
        // Only enable stars that have NOT been collected
        foreach (GameObject star in stars) {
            if (ApplicationModel.getStarCollected(sceneIndex, i++) == 0) {
                star.SetActive(true);
            }
            else {
                star.SetActive(false);
                starsCollected++;
            }
        }

        totalStarsCollected = starsCollected;
        totalStars = stars.Length;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Star") {
            other.gameObject.SetActive(false);

            GetComponent<AudioSource>().clip = Config.audioCoin;
            GetComponent<AudioSource>().Play();
            ApplicationModel.setStarCollected(sceneIndex, other.GetComponent<Star>().index);
            ++totalStarsCollected;
        }
    }

    public void clearSavedStars() {
        int i = 1;

        foreach (GameObject star in stars) {
            ApplicationModel.deleteStarCollected(sceneIndex, i++);
        }
    }
}
