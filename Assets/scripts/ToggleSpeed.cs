using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpeed : Toggle<Speed> {
    public override void notify(Speed speed) {
        SpeedChangeEvent e = new SpeedChangeEvent();
        e.Invoke(speed);
    }
}