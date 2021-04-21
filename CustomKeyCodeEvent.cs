using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomKeyCodeEvent : MonoBehaviour
{
    [SerializeField] String _keyCodeString;
    [SerializeField] UnityEvent _event;
    KeyCode _keyCode;

    void Awake()
    {
        _keyCode = (KeyCode)Enum.Parse(typeof(KeyCode), _keyCodeString, true);
    }

    void Update()
    {

        if (Input.GetKeyDown(_keyCode))
        {
            Debug.Log(_keyCode + " key was pressed");
            _event?.Invoke();
        }
    }

    public void DemoEvent()
    {
        Debug.Log("Demo event was triggered");
    }
}