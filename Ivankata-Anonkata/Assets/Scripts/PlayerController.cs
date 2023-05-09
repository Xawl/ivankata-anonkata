using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;              
    public float jumpForce = 5f;          
    public Transform groundCheck;         
    public LayerMask groundLayer;         

    private bool isJumping;       
    private bool isGrounded;      
    private Rigidbody2D rb;               

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        
        float move = Input.GetAxis("Horizontal");

        
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        //Flip ze sprit
        if (move < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (move > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        
        if (Input.GetKeyDown("space") && isGrounded)
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = false;
        }
    }
}