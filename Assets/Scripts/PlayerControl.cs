using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float jumpForce = 1f;
    [SerializeField] TextMeshProUGUI scoreText;

    int score = 0;
    Rigidbody2D rb;
    Animator anim;
    bool canJump;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        //scoreText.text = "0 / 25";
    }

    void FixedUpdate()
    {
        float xInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        switch (xInput)
        {
            case 0:
                anim.SetBool("isWalking", false);
                break;
            case 1:
                anim.SetBool("isWalking", true);
                transform.localScale = new Vector3(1, 1, 1);
                break;
            case -1:
                anim.SetBool("isWalking", true);
                transform.localScale = new Vector3(-1, 1, 1);
                break;
        }

        if ((Input.GetKey(KeyCode.W) && canJump) || (Input.GetKey(KeyCode.Space) && canJump))
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.E))
        {
            Attack();
        }

    }

    void Jump()
    {

        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        anim.SetBool("isJumping", true);

        canJump = false;
    }

    void Attack()
    {
        anim.SetTrigger("Attack");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" )
        {
            anim.SetBool("isJumping", false);

            canJump = true;
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Coin")
        {
            score++;
            col.gameObject.SetActive(false);
            scoreText.text = score + " / 25";
        }

    }
}
