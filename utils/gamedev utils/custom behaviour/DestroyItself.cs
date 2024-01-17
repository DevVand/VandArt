using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItself : MonoBehaviour
{
    public void destroy() { Destroy(this.gameObject); }
    public void destroy( float time ) { Invoke(nameof(destroy), time); }
}
