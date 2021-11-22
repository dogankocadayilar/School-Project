using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] float dampTime = 0.15f;
    [SerializeField] Transform target;
    private Vector3 velocity = Vector3.zero;
    float yPos;

    void Update()
    {
        if (target.position.x > 0)
        {
            if(target.position.y < -5.5f)
            {
                if(target.position.y > -12)
                {
                    yPos = -12.0f;
                }
                else
                {
                    yPos = -15.0f;
                }
            }
            else
            {
                yPos = 0;
            }

            Vector3 destination = new Vector3(target.position.x, yPos, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}
