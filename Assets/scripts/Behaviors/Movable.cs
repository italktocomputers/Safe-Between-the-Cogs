using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour {
    private void Start() {
        if (GetComponent<Speed>() == null) {
            throw new System.Exception("Object must have a Speed Component!");
        }

        if (GetComponent<Target>() == null) {
            throw new System.Exception("Object must have a Target Component!");
        }
    }

    void Update () {
        transform.position = Vector2.MoveTowards(transform.position, GetComponent<Target>().value, GetComponent<Speed>().value * Time.deltaTime);
    }
}
