using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] float dampTime = 0.15f;
    [SerializeField] Transform target;
    private Vector3 velocity = Vector3.zero;
    float yPos;

    // Update is called once per frame
    void Update()
    {
        if (target.position.x > 0)
        {
            if(target.position.y < -5.5f)
            {
                yPos = -14;
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
