using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    public float runSpeed = 40f;
   
    float horizontalMove = 0f;
   
    bool jump = false;
    

  

    void Update()
    {
        
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        Debug.Log(horizontalMove);

        if (Input.GetButtonDown("Jump"))
        {
            
            jump = true;
            animator.SetBool("jumping", true);
        }
    }

    public void Landing()
    {
        animator.SetBool("jumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
