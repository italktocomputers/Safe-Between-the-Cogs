using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour {
    public GameObject UI_StarsCollected;
    public GameObject UI_StarsTotal;
    public GameObject[] stars;
    public int sceneIndex;
    private int starsCollected = 0;
    private int totalStars = 0;

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

        setStarsCollected(starsCollected);
        setStarsTotal(stars.Length);
    }

    protected void setStarsCollected(int stars) {
        starsCollected = stars;
        UI_StarsCollected.GetComponent<Text>().text = stars.ToString();
    }

    protected void setStarsTotal(int stars) {
        totalStars = stars;
        UI_StarsTotal.GetComponent<Text>().text = stars.ToString();
    }

    protected void incStarsCollected() {
        starsCollected++;
        UI_StarsCollected.GetComponent<Text>().text = starsCollected.ToString();
    }

    public int getTotalStarsCollected() {
        int i = 1;

        foreach (GameObject star in stars) {
            if (ApplicationModel.getStarCollected(sceneIndex, i++) == 1) {
                starsCollected++;
            }
        }

        return starsCollected;
    }

    public int getTotalStars() {
        return totalStars;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Star") {
            GetComponent<AudioSource>().clip = Config.audioCoin;
            GetComponent<AudioSource>().Play();
            ApplicationModel.setStarCollected(sceneIndex, other.GetComponent<Star>().index);
            incStarsCollected();
        }
    }

    public void clearSavedStars() {
        int i = 1;

        foreach (GameObject star in stars) {
            ApplicationModel.deleteStarCollected(sceneIndex, i++);
        }
    }
}
