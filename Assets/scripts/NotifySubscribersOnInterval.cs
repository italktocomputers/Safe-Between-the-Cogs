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

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NotifySubscribersOnInterval : MonoBehaviour {
    public UnityEvent[] e;
    public int interval; // milliseconds
    private DateTime startTime;

    void Start () {
        startTime = DateTime.Now;
	}
	
	void Update () {
        DateTime now = DateTime.Now;

        TimeSpan timespan = (now - startTime).Duration();
        if (timespan.TotalMilliseconds >= interval) {
            notify();
            startTime = DateTime.Now;
        }
    }

    private void notify() {
        foreach (var sub in e) {
            sub.Invoke();
        }
    }
}
