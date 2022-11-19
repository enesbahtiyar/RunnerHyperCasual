using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    [SerializeField] Transform cameraTarget;
    [SerializeField] float speed = 10f;
    [SerializeField] Vector3 dist;
    [SerializeField] Transform lookTarget;
    private void LateUpdate()
    {
        Vector3 dPos = cameraTarget.position + dist;        Vector3 sPos = Vector3.Lerp(transform.position, dPos, speed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
}
