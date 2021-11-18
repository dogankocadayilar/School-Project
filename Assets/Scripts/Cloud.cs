using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    bool turn;
    void Update()
    {
        if(transform.position.x <= -20f)
        {
            turn = true;
        }
        else if(transform.position.x >= 60f)
        {
            turn = false;
        }

        if(turn)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
