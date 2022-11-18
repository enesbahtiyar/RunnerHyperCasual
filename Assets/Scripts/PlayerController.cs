using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float runningspeed = 10f;

    private void Update()
    {
        Vector3 newposition = new Vector3(transform.position.x, transform.position.y,transform.position.z + runningspeed * Time.deltaTime);
        transform.position = newposition;
    }
}
