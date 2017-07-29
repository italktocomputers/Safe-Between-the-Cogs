using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDynamicBodyTypeToRBAfterCollision : MonoBehaviour {
    private bool collision;
    private DateTime firstCollision;
    public float delay;

    private void Start () {
        collision = false;
    }

    private void Update() {
        if (collision) {
            DateTime now = DateTime.Now;

            TimeSpan timespan = (now - firstCollision).Duration();
            if (timespan.TotalSeconds >= delay) {
                fall();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Hero") {
            collision = true;
            firstCollision = DateTime.Now;
        }
    }

    private void fall() {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
