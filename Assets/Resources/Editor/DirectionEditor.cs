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
using UnityEditor;

[CustomEditor (typeof(Direction))]
public class DirectionEditor : Editor {
    SerializedProperty value;
    private int index = 0;

    void OnEnable() {
        value = serializedObject.FindProperty("value");

        if (value !=  null) {
            index = value.intValue;
        }
    }

    public override void OnInspectorGUI() {
        serializedObject.Update();

        GUIContent[] options = new GUIContent[2];
        options[0] = new GUIContent("Clockwise");
        options[1] = new GUIContent("Counterclockwise");

        index = EditorGUILayout.Popup(index, options);

        value.intValue = index;

        serializedObject.ApplyModifiedProperties();
    }
}
