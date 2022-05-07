using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyCodeUp : MonoBehaviour
{
    [SerializeField] KeyCode _keyCode;
    [SerializeField] UnityEvent _event;

    void Update()
    {
        if (Input.GetKeyUp(_keyCode))
        {
            Debug.Log(_keyCode + " Not Pressed");
            _event?.Invoke();
        }
    }

    public void DemoEvent()
    {
        Debug.Log("Demo event was triggered");
    }
}