using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed;
    public float jumpSpeed;

    private float move;
    private Rigidbody2D rb;
    
    public bool isGrounded = false;
    public Animator animator;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

   
    void Update()
    {
        move = Input.GetAxis("Horizontal") * runSpeed;

        rb.velocity = new Vector2(move , rb.velocity.y);

        if(move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        } else if(move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
        }

        animator.SetFloat("Speed", Mathf.Abs(move));




        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * runSpeed;



    }

   void RunAnimations()
    {
        animator.SetFloat("Speed", Mathf.Abs(move));
    }
}
