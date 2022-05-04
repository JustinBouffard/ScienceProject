using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    private Animator Animator;

    public CharacterController2D Controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    private void Awake()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimatePlayer();

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            Animator.SetBool("Jump", true);
        }

    }

    //move player
    private void FixedUpdate()
    {
        Controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        Animator.SetBool("Jump", false);

    }
    //animatePlayer
    private void AnimatePlayer()
    {
        if (horizontalMove != 0)
        {
            Animator.SetBool("Walk", true);
        }
        else
        {
            Animator.SetBool("Walk", false);
        }

    }  
    
    public void OnLanding()
    {
        Animator.SetBool("Jump", false);
    }

    //detroy player when falling
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DestroyBullet"))
        {
            Destroy(gameObject);
        }
    }

}//class
