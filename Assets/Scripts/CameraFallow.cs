using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] float dampTime = 0.15f;
    [SerializeField] Transform target;
    [SerializeField] float uMaxY = -5.5f;
    [SerializeField] float uBetweenY = -12f;
    [SerializeField] float uMinY = -15f;
    [SerializeField] float x = -7.0f;
    private Vector3 velocity = Vector3.zero;
    float yPos;

    void Update()
    {
        if (target.position.x > x)
        {
            if (target.position.y < uMaxY)
                yPos = (target.position.y > uBetweenY) ? uBetweenY : uMinY;
            else
                yPos = 0;

            Vector3 destination = new Vector3(target.position.x, yPos, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}
