using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventZoneBoth : MonoBehaviour
{

    public UnityEngine.Events.UnityEvent onTriggerEnter;
    void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }
    public UnityEngine.Events.UnityEvent onTriggerExit;
    void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }
}