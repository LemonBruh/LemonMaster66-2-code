using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyCodeBoth : MonoBehaviour
{
    [SerializeField] KeyCode _keyCode;
    [SerializeField] UnityEvent _keyDown;
    [SerializeField] UnityEvent _keyUp;

    void Update()
    {
        if (Input.GetKeyDown(_keyCode))
        {
            Debug.Log(_keyCode + " pressed");
            _keyDown?.Invoke();
        }

        if (Input.GetKeyUp(_keyCode))
        {
            Debug.Log(_keyCode + " Un-Pressed");
            _keyUp?.Invoke();
        }
    }

    public void DemoEvent()
    {
        Debug.Log("Demo event was triggered");
    }
}