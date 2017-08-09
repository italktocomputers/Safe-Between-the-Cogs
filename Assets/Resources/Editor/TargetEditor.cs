using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ToggleTarget))]
public class TargetEditor : Editor {
    SerializedProperty[] values = new SerializedProperty[20];
    private int i = 0;

    void OnEnable() {
        values[0] = serializedObject.FindProperty("items");

        while (serializedObject.FindProperty("items").Next(false)) {
            values[++i] = serializedObject.FindProperty("items");
        }

        foreach (SerializedProperty p in values) {
            Debug.Log(p.vector2Value);
        }
    }

    public override void OnInspectorGUI() {
        int k = 0;
        serializedObject.Update();

        EditorGUILayout.IntField("Age", 3);

        foreach(SerializedProperty p in values) {
            Vector2 val = EditorGUILayout.Vector2Field("Target"+k, values[k].vector2Value);
            values[k].vector2Value = val;
            k++;
        }

        serializedObject.ApplyModifiedProperties();
    }
}
