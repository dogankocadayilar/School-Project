using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncers : MonoBehaviour
{
    [SerializeField] Animator anim;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            anim.SetTrigger("isBouncing");
        }
    }
}
