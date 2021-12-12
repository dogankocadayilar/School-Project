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
    [SerializeField] float minX = -7.0f;
    [SerializeField] float maxX = -7.0f;
    [SerializeField] float plusY = 0.0f;
    private Vector3 velocity = Vector3.zero;
    Vector2 pos;

    void Update()
    {
        if (target.position.x > minX && target.position.x < maxX)
            pos.x = target.position.x;
        else
            pos.x = transform.position.x;

        if (target.position.y < uMaxY)
            pos.y = (target.position.y > uBetweenY + plusY) ? uBetweenY : uMinY;
        else
            pos.y = 0;

        Vector3 destination = new Vector3(pos.x, pos.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);

    }
}
