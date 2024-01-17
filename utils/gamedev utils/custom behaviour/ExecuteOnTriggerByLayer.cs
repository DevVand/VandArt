using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExecuteOnTriggerByLayer : MonoBehaviour
{
    public LayerMask layerMask;
    public UnityEvent events;
    public UnityEvent exitEvents;

    private void OnTriggerEnter(Collider other)
    {
        print("entered");
        if (((1 << other.gameObject.layer) & layerMask) != 0)
        {
            print("event called");
            events.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        print("exited");
        if (((1 << other.gameObject.layer) & layerMask) != 0)
        {
            print("event uncalled");
            exitEvents.Invoke();
        }
    }
}
