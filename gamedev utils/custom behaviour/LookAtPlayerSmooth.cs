using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayerSmooth : MonoBehaviour
{
    public float smooth = 10;

    public Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>().returnCamera().transform;
    }

    // Update is called once per frame
    void Update()
    {

        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
    }
}
