using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDirection : Toggle<Direction> {
    public override void notify(Direction direction) {
        DirectionChangeEvent e = new DirectionChangeEvent();
        e.Invoke(direction);
    }
}