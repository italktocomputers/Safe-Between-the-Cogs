﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level2 : Level {
    public GameObject gear1;
    public GameObject gear2;
    public GameObject donut1;
    public GameObject switch1;

    override public void init() {

    }

    override public string getLevelName() {
        return "2";
    }

    public void enablePlatform1() {
        //platform1.GetComponent<Oscolate>().enabled = true;
    }

    public void enablePlatform2() {
        //platform2.GetComponent<Oscolate>().enabled = true;
    }

    public void actionsForCheckpoint1() {
        
    }

    public void actionsForCheckpoint2() {
        
    }

    public void actionsForCheckpoint3() {
        
    }

    public void actionsForCheckpoint4() {
        
    }

    public void actionsForCheckpoint5() {
        
    }

    public void actionsForCheckpoint6() {
        
    }

    public void actionsForCheckpoint7() {
        
    }

    public void actionsForCheckpoint8() {
        
    }

    public void actionsForCheckpoint9() {
        
    }

    public void actionsForCheckpoint10() {
        
    }

    public void toggleDonut1Rotation() {
        Rotate r = donut1.GetComponent<Rotate>();
        SpriteRenderer ren = switch1.GetComponent<SpriteRenderer>();
        Sprite on = Resources.Load("BlueBlock", typeof(Sprite)) as Sprite;
        Sprite off = Resources.Load("YellowBlock", typeof(Sprite)) as Sprite;

        if (r.direction == "left") {
            r.direction = "right";
            ren.sprite = on;
        }
        else {
            r.direction = "left";
            ren.sprite = off;
        }
    }
}