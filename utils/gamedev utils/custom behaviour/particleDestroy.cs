using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDestroy : MonoBehaviour
{
    private ParticleSystem particle;
    [SerializeField] float timer = 0;
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        if (timer == 0)
            StartCoroutine(update());
        else
            Invoke(nameof(stop), timer);
    }
    public void stop() { 
        particle.loop=false;
        particle.emissionRate = 0;
        Invoke(nameof(destroy), 1);
    }

    public void destroy() { Destroy(gameObject); }

    IEnumerator update() {
        while (true) {
            if (!particle.IsAlive())
                Destroy(gameObject);
            yield return null;
        }
    }
}
