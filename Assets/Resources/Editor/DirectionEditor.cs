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
