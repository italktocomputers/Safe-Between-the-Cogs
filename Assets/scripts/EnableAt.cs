﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Trigger an event after coordinates have been surpassed.  
public class EnableAt : MonoBehaviour {
    public GameObject hero;
    public float distanceTrigger;
    protected bool triggered = false;
    public UnityEvent e;

    private void Update () {
        if (triggered == false) {
            float currentDistance = Vector2.Distance(hero.transform.position, transform.position);

            if (currentDistance <= distanceTrigger) {
                triggered = true;
                e.Invoke();
            }
        }
    }
}