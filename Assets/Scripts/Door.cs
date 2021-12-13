using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Transform secondDoor;
    [SerializeField] Animator anim;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            bool isOpen = col.gameObject.GetComponent<PlayerControl>().isOpen;
            if (isOpen)
            {
                anim.SetTrigger("isTriggered");
                col.transform.position = secondDoor.position;
            }
        }
    }
}
