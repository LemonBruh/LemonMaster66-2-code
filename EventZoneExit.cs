using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventZoneExit : MonoBehaviour
{
    
        public UnityEngine.Events.UnityEvent onTriggerEnterExit;
        void OnTriggerExit(Collider other)
        {
            onTriggerEnterExit.Invoke();
    }
}