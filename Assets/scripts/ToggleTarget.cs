using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTarget : Toggle<Target> {
    public override void notify(Target target) {
        TargetChangeEvent e = new TargetChangeEvent();
        e.Invoke(target);
    }
}
