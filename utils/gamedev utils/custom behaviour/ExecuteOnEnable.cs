using UnityEngine;
using UnityEngine.Events;

public class ExecuteOnEnable : MonoBehaviour
{
    public UnityEvent action;
    private void OnEnable()
    {
        action.Invoke();
    }

    void destroyThis()
    {
        Destroy(this.gameObject);
    }
}
