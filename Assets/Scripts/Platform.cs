using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] Vector3 endPos;
    [SerializeField] float speed = 1f;
    Vector3 startPos;
    bool switching;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        UpAndDown();
    }

    void UpAndDown()
    {
        if(!switching)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        }
        else if (switching)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
        }

        if (transform.position == endPos)
        {
            switching = true;
        }
        else if (transform.position == startPos)
        {
            switching = false;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            coll.collider.transform.SetParent(transform);
        }
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.collider.transform.SetParent(null);
        }
    }
}
