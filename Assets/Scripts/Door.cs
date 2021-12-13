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
                StartCoroutine(DoorAnim(col.transform));

            }
        }
    }

    IEnumerator DoorAnim(Transform col)
    {
        anim.SetTrigger("isTriggered");
        yield return new WaitForSeconds(0.2f);
        col.position = secondDoor.position;
    }
}
