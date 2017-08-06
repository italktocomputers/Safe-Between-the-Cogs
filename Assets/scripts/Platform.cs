using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "Hero") {
            other.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.transform.tag == "Hero") {
            other.transform.parent = null;
        }
    }
}
