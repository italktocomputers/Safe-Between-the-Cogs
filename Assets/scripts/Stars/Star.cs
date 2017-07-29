using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {
    public int index;

    private void OnTriggerEnter2D(Collider2D other) {
        gameObject.SetActive(false);
    }
}
