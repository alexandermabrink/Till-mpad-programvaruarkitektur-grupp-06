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
    public float jumpSpeed;
    public bool facingRight;
    public float maxSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(move));

        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        Debug.Log(facingRight);
        
        if(move > 0 && !facingRight)
        {
           flip();
        }else if(move < 0 && facingRight)   
        {
            flip();
        }
            

        void flip()
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        
        
    }
}
