using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscolate : MonoBehaviour {
    public float speed1;
    public float speed2;
    public Vector2 start;
    public Vector2 finish;
    protected Vector2 target;
    protected float speedToUse;

    private void Start() {
        GetComponent<AudioSource>().enabled = true;
        GetComponent<AudioSource>().Play();

        target = finish;
        speedToUse = speed1;
    }

    private void Update() {
        float distanceFromStart = Vector2.Distance(transform.position, start);
        float distanceFromFinish = Vector2.Distance(transform.position, finish);

        if (distanceFromFinish == 0.0f) {
            speedToUse = speed2;
            target = start;
        }

        if (distanceFromStart == 0.0f) {
            speedToUse = speed1;
            target = finish;
        }

        transform.position = Vector2.MoveTowards(transform.position, target, speedToUse * Time.deltaTime);
    }

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
