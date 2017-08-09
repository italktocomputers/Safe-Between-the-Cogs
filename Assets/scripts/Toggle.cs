using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

abstract public class Toggle<T> : MonoBehaviour {
    public T[] items;
    private int index = 0;
    abstract public void notify(T item);

    public void toggle() {
        T target = gameObject.GetComponent<T>();

        if (index == items.Length) {
            index = 0;
        }

        notify(items[index++]);
    }
}
