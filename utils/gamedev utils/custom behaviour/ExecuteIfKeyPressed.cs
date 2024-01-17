using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ExecuteIfKeyPressed : MonoBehaviour
{

    public UnityEvent execute;

    public void OnKey(InputAction.CallbackContext context)
    {
        if (context.performed)
            execute.Invoke();
    }
}
