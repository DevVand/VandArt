using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayerOnlyY : MonoBehaviour
{
    public Transform player;
    [SerializeField] float offset=0;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>().returnCamera().transform;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Rad2Deg * Mathf.Atan2(transform.position.x- player.position.x, transform.position.z- player.position.z);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle+offset, transform.eulerAngles.z);
    }
}
