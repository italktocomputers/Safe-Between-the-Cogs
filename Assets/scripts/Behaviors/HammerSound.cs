using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSound : MonoBehaviour {
    public float ground;

    private void Update () {
		if (transform.position.y <= ground) {
            GetComponent<AudioSource>().Play();
        }
	}
}
