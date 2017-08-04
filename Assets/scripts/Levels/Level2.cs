using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level2 : Level {
    public GameObject gear1;
    public GameObject gear2;
    public GameObject gear3;
    public GameObject gear4;
    public GameObject gear5;
    public GameObject donut1;
    public GameObject switch1;

    public GameObject platform1;
    public GameObject platform2;

    public GameObject hammer1;
    public GameObject hammer2;
    public GameObject hammer3;
    public GameObject hammer4;
    public GameObject hammer5;
    public GameObject hammer6;
    public GameObject hammer7;
    public GameObject hammer8;
    public GameObject hammer9;

    override public void init() {

    }

    override public string getLevelName() {
        return "2";
    }

    public void enablePlatform1() {
        platform1.GetComponent<Oscolate>().enabled = true;
    }

    public void enablePlatform2() {
        platform2.GetComponent<Oscolate>().enabled = true;
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
        Rotate rotate = donut1.GetComponent<Rotate>();
        SpriteRenderer renderer = switch1.GetComponent<SpriteRenderer>();
        Sprite on = Resources.Load("BlueBlock", typeof(Sprite)) as Sprite;
        Sprite off = Resources.Load("YellowBlock", typeof(Sprite)) as Sprite;

        if (rotate.direction == "left") {
            rotate.direction = "right";
            renderer.sprite = off;
        }
        else {
            rotate.direction = "left";
            renderer.sprite = on;
        }
    }

    public void toggleGear5Rotation() {
        Rotate rotate = gear5.GetComponent<Rotate>();

        if (rotate.direction == "left") {
            rotate.direction = "right";
        }
        else {
            rotate.direction = "left";
        }
    }

    public void toggleHammer7Speed() {
        Oscolate oscolate = hammer7.GetComponent<Oscolate>();

        if (oscolate.speed1 == 2.0f) {
            oscolate.speed1 = 3.0f;
            oscolate.speed2 = 3.0f;
        }
        else {
            oscolate.speed1 = 2.0f;
            oscolate.speed2 = 2.0f;
        }
    }

    public void toggleHammer8Speed() {
        Oscolate oscolate = hammer8.GetComponent<Oscolate>();

        if (oscolate.speed1 == 2.0f) {
            oscolate.speed1 = 4.0f;
            oscolate.speed2 = 4.0f;
        }
        else {
            oscolate.speed1 = 2.0f;
            oscolate.speed2 = 2.0f;
        }
    }

    public void toggleHammer9Speed() {
        Oscolate oscolate = hammer9.GetComponent<Oscolate>();

        if (oscolate.speed1 == 2.0f) {
            oscolate.speed1 = 5.0f;
            oscolate.speed2 = 5.0f;
        }
        else {
            oscolate.speed1 = 2.0f;
            oscolate.speed2 = 2.0f;
        }
    }
}
