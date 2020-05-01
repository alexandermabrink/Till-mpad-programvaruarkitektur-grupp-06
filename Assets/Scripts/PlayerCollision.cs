using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Animator animator;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Traps")
        {
            animator.SetBool("Dead", true);
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
