using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyCodeEvent : MonoBehaviour
{
    [SerializeField] KeyCode _keyCode;
    [SerializeField] UnityEvent _event;

    void Update()
    {
        if (Input.GetKeyDown(_keyCode))
        {
            Debug.Log(_keyCode + " pressed");
            _event?.Invoke();
        }
    }

    public void DemoEvent()
    {
        Debug.Log("Demo event was triggered");
    }
}