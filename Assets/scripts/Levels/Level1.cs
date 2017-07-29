using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level1 : Level {
    public GameObject gear1;
    public GameObject gear2;
    public GameObject gear3;
    public GameObject gear4;
    public GameObject gear5;
    public GameObject gear6;
    public GameObject gear7;
    public GameObject gear8;
    public GameObject gear9;
    public GameObject gear10;
    public GameObject gear11;
    public GameObject gear12;
    public GameObject gear13;
    public GameObject gear14;
    public GameObject gear15;
    public GameObject gear16;
    public GameObject gear17;

    public GameObject hammer1;
    public GameObject hammer2;
    public GameObject hammer3;
    public GameObject hammer4;
    public GameObject hammer5;
    public GameObject hammer6;
    public GameObject hammer7;
    public GameObject hammer8;

    public GameObject platform1;
    public GameObject platform2;

    public GameObject fork1;

    public GameObject gearBlur1;
    public GameObject gearBlur2;
    public GameObject gearBlur3;
    public GameObject gearBlur4;
    public GameObject gearBlur5;
    public GameObject gearBlur6;
    public GameObject gearBlur7;
    public GameObject gearBlur8;
    public GameObject gearBlur9;
    public GameObject gearBlur10;
    public GameObject gearBlur11;
    public GameObject gearBlur12;

    override public void init() {
        gear1.SetActive(false);
        gear2.SetActive(false);
        gear3.SetActive(false);
        gear4.SetActive(false);
        gear5.SetActive(false);
        gear6.SetActive(false);
        gear7.SetActive(false);
        gear8.SetActive(false);
        gear9.SetActive(false);
        gear10.SetActive(false);
        gear11.SetActive(false);
        gear12.SetActive(false);
        gear13.SetActive(false);
        gear14.SetActive(false);
        gear15.SetActive(false);
        gear16.SetActive(false);
        gear17.SetActive(false);

        hammer1.SetActive(false);
        hammer2.SetActive(false);
        hammer3.SetActive(false);
        hammer4.SetActive(false);
        hammer5.SetActive(false);
        hammer6.SetActive(false);
        hammer7.SetActive(false);
        hammer8.SetActive(false);

        platform1.SetActive(false);
        platform2.SetActive(false);

        fork1.SetActive(false);

        gearBlur1.SetActive(false);
        gearBlur2.SetActive(false);
        gearBlur3.SetActive(false);
        gearBlur4.SetActive(false);
        gearBlur5.SetActive(false);
        gearBlur6.SetActive(false);
        gearBlur7.SetActive(false);
        gearBlur8.SetActive(false);
        gearBlur9.SetActive(false);
        gearBlur10.SetActive(false);
        gearBlur11.SetActive(false);
        gearBlur12.SetActive(false);
    }

    override public string getLevelName() {
        return "1";
    }

    public void enablePlatform1() {
        platform1.GetComponent<Oscolate>().enabled = true;
    }

    public void enablePlatform2() {
        platform2.GetComponent<Oscolate>().enabled = true;
    }

    public void switchRotationOfGear() {
        Rotate r = gear12.GetComponent<Rotate>();

        if (r.direction == "left") {
            r.direction = "right";
        }
        else {
            r.direction = "left";
        }
    }

    public void actionsForCheckpoint1() {
        gear1.SetActive(true);
        gear2.SetActive(true);
        gear3.SetActive(true);

        hammer1.SetActive(true);
        hammer2.SetActive(true);

        platform1.SetActive(true);

        fork1.SetActive(true);
    }

    public void actionsForCheckpoint2() {
        gearBlur1.SetActive(true);
        gearBlur2.SetActive(true);

        gear3.SetActive(true);
        gear4.SetActive(true);

        platform1.SetActive(true);

        fork1.SetActive(true);
    }

    public void actionsForCheckpoint3() {
        gear1.SetActive(false);
        gear2.SetActive(false);
        gear3.SetActive(false);

        hammer1.SetActive(false);
        hammer2.SetActive(false);

        platform1.SetActive(false);

        fork1.SetActive(false);

        gearBlur1.SetActive(false);
        gearBlur2.SetActive(false);

        gear4.SetActive(true);
        gear5.SetActive(true);
        gear6.SetActive(true);
    }

    public void actionsForCheckpoint4() {
        gear4.SetActive(false);
        gear5.SetActive(false);

        gear6.SetActive(true);
        gear7.SetActive(true);

        gearBlur3.SetActive(false);
        gearBlur4.SetActive(false);
    }

    public void actionsForCheckpoint5() {
        gear6.SetActive(false);

        gear7.SetActive(true);
        gear8.SetActive(true);
        gear9.SetActive(true);
        gear10.SetActive(true);
        gear11.SetActive(true);

        gearBlur5.SetActive(true);
        gearBlur6.SetActive(true);
        gearBlur7.SetActive(true);
        gearBlur8.SetActive(true);

        platform2.SetActive(true);

        hammer3.SetActive(true);
        hammer4.SetActive(true);
        hammer5.SetActive(true);
        hammer6.SetActive(true);
        hammer7.SetActive(true);
        hammer8.SetActive(true);
    }

    public void actionsForCheckpoint6() {
        gear7.SetActive(false);
        gear8.SetActive(false);
        gear9.SetActive(false);
        gear10.SetActive(false);

        platform2.SetActive(false);

        gearBlur3.SetActive(false);
        gearBlur4.SetActive(false);

        gearBlur5.SetActive(false);
        gearBlur6.SetActive(false);
        gearBlur7.SetActive(false);
        gearBlur8.SetActive(false);

        gear12.SetActive(true);

        hammer3.SetActive(true);
        hammer4.SetActive(true);
        hammer5.SetActive(true);
        hammer6.SetActive(true);
        hammer7.SetActive(true);
        hammer8.SetActive(true);
    }

    public void actionsForCheckpoint7() {
        gear12.SetActive(true);

        hammer3.SetActive(true);
        hammer4.SetActive(true);
        hammer5.SetActive(true);
        hammer6.SetActive(true);
        hammer7.SetActive(true);
        hammer8.SetActive(true);

        gear13.SetActive(true);
    }

    public void actionsForCheckpoint8() {
        gear11.SetActive(false);
        gear12.SetActive(false);

        hammer3.SetActive(false);
        hammer4.SetActive(false);
        hammer5.SetActive(false);
        hammer6.SetActive(false);
        hammer7.SetActive(false);
        hammer8.SetActive(false);

        gear13.SetActive(true);
        gear14.SetActive(true);
        gear15.SetActive(true);
        gear16.SetActive(true);
        gear17.SetActive(true);

        gearBlur9.SetActive(true);
        gearBlur10.SetActive(true);
        gearBlur11.SetActive(true);
        gearBlur12.SetActive(true);
    }

    public void actionsForCheckpoint9() {
        gear13.SetActive(false);

        gearBlur9.SetActive(false);
        gearBlur10.SetActive(false);

        gearBlur11.SetActive(true);
        gearBlur12.SetActive(true);

        gear14.SetActive(true);
        gear15.SetActive(true);
        gear16.SetActive(true);
        gear17.SetActive(true);
    }
}
