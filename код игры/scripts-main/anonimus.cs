//скрипт персонажа
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anonimus : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float moveInput;
    private Vector2 moveVelocity; 
    private Animator anim;
    private bool facingRight = true;
    public float jumpforce;
    private bool isgrounded;
    public Transform feetpos;
    public float checkradius;
    public LayerMask ground;
    public GameObject key;
    public bool kluchvruke = false;
    public camm cum;
    
   


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {   if(cum.pause == false)
        {
            isgrounded = Physics2D.OverlapCircle(feetpos.position, checkradius, ground);
            if (isgrounded == true && Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpforce;


            }
        }
        
           
      
        

    }
    private void FixedUpdate()
    {
        if(cum.pause == false)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
        
        
            
        
        if (!facingRight && moveInput > 0)
        {
            flip();
        }
        else if (facingRight && moveInput < 0)
        {
            flip();
        }
        if(moveInput == 0)
        {
            anim.SetBool("isrun", false && isgrounded == true);
        }
        else
        {
            anim.SetBool("isrun", true);
        }
       
    }
    private void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ëóí"))
        {
            other.gameObject.SetActive(false);
            key.SetActive(true);
            kluchvruke = true;

        }    
            
    }
}
