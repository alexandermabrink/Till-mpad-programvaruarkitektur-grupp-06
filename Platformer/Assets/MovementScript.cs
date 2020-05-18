using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb;
    public float speed;
    public bool facingRight;
    public float maxSpeed = 10f;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 150f;
        


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

            float move = Input.GetAxis("Horizontal");
            animator.SetFloat("speed", Mathf.Abs(move));

            rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
            Debug.Log(grounded);

            if (move > 0 && !facingRight)
            {
                Flip();
            }
            else if (move < 0 && facingRight)
            {
                Flip();
            }
            Debug.Log(rb.velocity.y);   
        
    }


    private void Update()
    {

        if ((rb.velocity.y < 0.01 && rb.velocity.y > -0.01) && Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(new Vector2(0, jumpForce));
           
        }
        

    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }



}
