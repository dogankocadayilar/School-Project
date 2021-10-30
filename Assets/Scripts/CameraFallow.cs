using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] float dampTime = 0.15f;
    [SerializeField] Transform target;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (target.position.x > 0)
        {
            Vector3 destination = new Vector3(target.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}
