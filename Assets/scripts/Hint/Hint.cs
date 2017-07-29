using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// This behavior must be attached to any GameObject that is a hint.  Set the index of the hint 
// in the UnityUI.
//
public class Hint : MonoBehaviour {
    public int index;

    //
    // When colliding with a Hint, the Hint will be removed from the scene so not to display the
    // same hint over and over.
    //
    private void OnTriggerEnter2D(Collider2D other) {
        gameObject.SetActive(false);
    }
}
