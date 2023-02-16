using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExecuteOnTriggerByTag : MonoBehaviour
{
    public string searchTag = "";
    public UnityEvent events;
    public UnityEvent exitEvents;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("searchTag"))
        {
            events.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("searchTag"))
        {
            exitEvents.Invoke();
        }
    }
}
