using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float runningspeed = 10f;
    [SerializeField] float xSpeed = 10f;
    [SerializeField] float limitX;

    float touchXdelta = 0;
    float newX = 0;

    private void Update()
    {
        ProcessTouchInput();
    }

    private void ProcessTouchInput()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //Debug.Log(Input.GetTouch(0).deltaPosition.x / Screen.width);
            touchXdelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
        }
        else if(Input.GetMouseButton(0))
        {
            touchXdelta = Input.GetAxis("Mouse X");
        }
        else
        {
            touchXdelta = 0;
        }
        newX = transform.position.x + xSpeed * touchXdelta * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);

        Vector3 newposition = new Vector3(newX, transform.position.y, transform.position.z + runningspeed * Time.deltaTime);
        transform.position = newposition;
    }
}
