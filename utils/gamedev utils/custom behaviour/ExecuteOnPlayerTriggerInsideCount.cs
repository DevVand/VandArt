using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExecuteOnPlayerTriggerInsideCount : MonoBehaviour
{
    public UnityEvent entered;
    public UnityEvent exited;
    public int inside = 0;
    bool canAlterEntry = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canAlterEntry)
        {
            inside++;
            if(inside==1)
                entered.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && canAlterEntry)
        {
            inside--;
            if (inside==0)
                exited.Invoke();
        }
    }
    public bool isInside() { return inside > 0; }
    public void resetEntry()
    {
        canAlterEntry = false;
        Invoke(nameof(canAlterEntryTrue), .2f);
        inside = 0;
    }
    public void setEntry(int to)
    {
        canAlterEntry = false;
        Invoke(nameof(canAlterEntryTrue), .2f);
        inside = to;
    }

    public void canAlterEntryTrue() { canAlterEntry = true; }
}
