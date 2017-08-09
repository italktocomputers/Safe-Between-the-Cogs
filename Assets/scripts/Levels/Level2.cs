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
    public GameObject gear6;
    public GameObject gear7;
    public GameObject gear8;
    public GameObject gear9;

    public GameObject donut1;

    public GameObject switch1;
    public GameObject switch2;

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
    public GameObject hammer10;

    public GameObject OscillatingBrick1;
    public GameObject OscillatingBrick2;
    public GameObject OscillatingBrick3;

    public override void disableALLGameObjects() {
        
    }

    override public void init() {

    }

    override public string getLevelName() {
        return "2";
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

    public void switchDonut1Rotation() {
        donut1.GetComponent<Direction>().setDirection(DirectionUnit.Counterclockwise);
    }

    public void switchGear7Direction() {
        gear7.GetComponent<Direction>().setDirection(DirectionUnit.Counterclockwise);
    }

    public void switchGear8Direction() {
        gear8.GetComponent<Direction>().setDirection(DirectionUnit.Clockwise);
    }

    public void switchGear9Direction() {
        gear9.GetComponent<Direction>().setDirection(DirectionUnit.Counterclockwise);
    }
}
