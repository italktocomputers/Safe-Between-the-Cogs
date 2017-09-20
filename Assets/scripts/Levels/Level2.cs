/*
 * Copyright (C) 2017 Andrew Schools
 * 
 * This program is free software: you can redistribute it and/or modify it under the terms 
 * of the GNU General Public License as published by the Free Software Foundation, either 
 * version 3 of the License, or (at your option) any later version.
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
 * See the GNU General Public License for more details.
 * You should have received a copy of the GNU General Public License along with this program. 
 * If not, see http://www.gnu.org/licenses/.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level2 : MonoBehaviour, ILevel {
    public GameObject gear1;
    public GameObject gear2;
    public GameObject gear3;
    public GameObject gear4;
    public GameObject gear5;
    public GameObject gear6;
    public GameObject gear7;
    public GameObject gear8;
    public GameObject gear9;

    public GameObject gearBlur1;
    public GameObject gearBlur2;
    public GameObject gearBlur3;
    public GameObject gearBlur4;
    public GameObject gearBlur5;
    public GameObject gearBlur6;

    public GameObject donut1;

    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;

    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;

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
    public GameObject hammer11;
    public GameObject hammer12;
    public GameObject hammer13;
    public GameObject hammer14;
    public GameObject hammer15;
    public GameObject hammer16;
    public GameObject hammer17;
    public GameObject hammer18;
    public GameObject hammer19;
    public GameObject hammer20;
    public GameObject hammer21;

    public GameObject OscillatingBrick1;
    public GameObject OscillatingBrick2;
    public GameObject OscillatingBrick3;
    public GameObject OscillatingBrick4;
    public GameObject OscillatingBrick5;

    public void disableAllGameObjects() {
        gear1.SetActive(false);
        gear2.SetActive(false);
        gear3.SetActive(false);
        gear4.SetActive(false);
        gear5.SetActive(false);
        gear6.SetActive(false);
        gear7.SetActive(false);
        gear8.SetActive(false);
        gear9.SetActive(false);

        gearBlur1.SetActive(false);
        gearBlur2.SetActive(false);
        gearBlur3.SetActive(false);
        gearBlur4.SetActive(false);
        gearBlur5.SetActive(false);
        gearBlur6.SetActive(false);

        donut1.SetActive(false);

        platform1.SetActive(false);
        platform2.SetActive(false);
        platform3.SetActive(false);

        hammer1.SetActive(false);
        hammer2.SetActive(false);
        hammer3.SetActive(false);
        hammer4.SetActive(false);
        hammer5.SetActive(false);
        hammer6.SetActive(false);
        hammer7.SetActive(false);
        hammer8.SetActive(false);
        hammer9.SetActive(false);
        hammer10.SetActive(false);
        hammer11.SetActive(false);
        hammer12.SetActive(false);
        hammer13.SetActive(false);
        hammer14.SetActive(false);
        hammer15.SetActive(false);
        hammer16.SetActive(false);
        hammer17.SetActive(false);
        hammer18.SetActive(false);
        hammer19.SetActive(false);
        hammer20.SetActive(false);
        hammer21.SetActive(false);

        OscillatingBrick1.SetActive(false);
        OscillatingBrick2.SetActive(false);
        OscillatingBrick3.SetActive(false);
        OscillatingBrick4.SetActive(false);
        OscillatingBrick5.SetActive(false);
    }

    public void init() {

    }

    public string getLevelName() {
        return "Scene2";
    }

    public void actionsForCheckpoint1() {
        gear1.SetActive(true);
        gear2.SetActive(true);
        gearBlur1.SetActive(true);
        gearBlur2.SetActive(true);
    }

    public void actionsForCheckpoint2() {
        gear1.SetActive(false);

        gear2.SetActive(true);

        donut1.SetActive(true);

        hammer1.SetActive(true);
        hammer2.SetActive(true);
        hammer3.SetActive(true);
        hammer4.SetActive(true);
        hammer5.SetActive(true);
        hammer6.SetActive(true);

    }

    public void actionsForCheckpoint3() {
        gear1.SetActive(false);
        gear2.SetActive(false);

        gearBlur1.SetActive(false);
        gearBlur2.SetActive(false);

        hammer1.SetActive(true);
        hammer2.SetActive(true);
        hammer3.SetActive(true);
        hammer4.SetActive(true);
        hammer5.SetActive(true);
        hammer6.SetActive(true);

        gear3.SetActive(true);
        gear4.SetActive(true);
    }

    public void actionsForCheckpoint4() {
        donut1.SetActive(false);

        gear5.SetActive(true);

        hammer4.SetActive(true);
        hammer5.SetActive(true);
        hammer6.SetActive(true);

        gear3.SetActive(true);
        gear4.SetActive(true);

        gearBlur3.SetActive(true);
        gearBlur4.SetActive(true);
        gearBlur5.SetActive(true);
        gearBlur6.SetActive(true);

        platform1.SetActive(true);
        platform2.SetActive(true);
    }

    public void actionsForCheckpoint5() {
        gear3.SetActive(false);

        hammer4.SetActive(false);
        hammer5.SetActive(false);
        hammer6.SetActive(false);

        gear5.SetActive(true);
        gear6.SetActive(true);

        hammer7.SetActive(true);
        hammer8.SetActive(true);
        hammer9.SetActive(true);

        OscillatingBrick1.SetActive(true);
        OscillatingBrick2.SetActive(true);
        OscillatingBrick3.SetActive(true);

    }

    public void actionsForCheckpoint6() {
        gear3.SetActive(false);
        gear4.SetActive(false);

        gearBlur3.SetActive(false);
        gearBlur4.SetActive(false);
        gearBlur5.SetActive(false);
        gearBlur6.SetActive(false);

        OscillatingBrick1.SetActive(true);
        OscillatingBrick2.SetActive(true);
        OscillatingBrick3.SetActive(true);

        gear5.SetActive(true);
        gear6.SetActive(true);

        hammer7.SetActive(true);
        hammer8.SetActive(true);
        hammer9.SetActive(true);
        hammer10.SetActive(true);

        gear7.SetActive(true);
        gear8.SetActive(true);
        gear9.SetActive(true);

        platform3.SetActive(true);
    }

    public void actionsForCheckpoint7() {
        gear5.SetActive(false);
        gear6.SetActive(false);
        gear7.SetActive(false);

        hammer7.SetActive(false);
        hammer8.SetActive(false);
        hammer9.SetActive(false);

        platform3.SetActive(false);

        OscillatingBrick1.SetActive(false);
        OscillatingBrick2.SetActive(false);
        OscillatingBrick3.SetActive(false);

        gear8.SetActive(true);
        gear9.SetActive(true);

        hammer10.SetActive(true);

        gear8.SetActive(true);
        gear9.SetActive(true);
        
        OscillatingBrick4.SetActive(true);
        OscillatingBrick5.SetActive(true);

        hammer11.SetActive(true);
        hammer12.SetActive(true);
        hammer13.SetActive(true);
        hammer14.SetActive(true);
        hammer15.SetActive(true);
        hammer16.SetActive(true);
        hammer17.SetActive(true);
        hammer18.SetActive(true);
        hammer19.SetActive(true);
        hammer20.SetActive(true);
        hammer21.SetActive(true);
    }

    public void actionsForCheckpoint8() {
        gear8.SetActive(true);
        gear9.SetActive(true);

        OscillatingBrick4.SetActive(true);
        OscillatingBrick5.SetActive(true);

        hammer11.SetActive(true);
        hammer12.SetActive(true);
        hammer13.SetActive(true);
        hammer14.SetActive(true);
        hammer15.SetActive(true);
        hammer16.SetActive(true);
        hammer17.SetActive(true);
        hammer18.SetActive(true);
        hammer19.SetActive(true);
        hammer20.SetActive(true);
        hammer21.SetActive(true);
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

    public void onWall5Collision() {
        GetComponent<Jumbotron>().add("Too bad there wasn't a switch to move this!");
    }
}
