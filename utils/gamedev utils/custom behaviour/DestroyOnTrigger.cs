using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] objs;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { destroy(); }
    }
    public void destroy()
    {
        foreach (GameObject obj in objs)
        {
            Destroy(obj);
        }
        Destroy(this.gameObject);
    }
}
