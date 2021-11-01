using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncers : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] float bouncerForce = 1f;


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.GetComponent<Rigidbody2D>() != null)
        {
            anim.SetTrigger("isBouncing");
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bouncerForce, ForceMode2D.Impulse);
        }
    }
}
