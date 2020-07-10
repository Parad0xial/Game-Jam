using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedIncrease;
    public float speed;
    public float jumpForce;
    private float moveInput;

    public Rigidbody2D rb;

    void start(){
     rb = GetComponent<Rigidbody2D>(); 
	}

    void FixedUpdate(){
     moveInput = Input.GetAxisRaw("Horizontal");


    if (Input.GetKey(KeyCode.D))
         {
             rb.velocity = new Vector2(speed, rb.velocity.y);
         }
 
    if (Input.GetKey(KeyCode.A))
         {
             rb.velocity = new Vector2(-speed, rb.velocity.y);
         }
    
    if (Input.GetKeyDown("space"))
         {
             rb.velocity = new Vector2(rb.velocity.x, jumpForce);
         }
     
     if(moveInput != 0){
      speed = speed + speedIncrease;
	 }
     
	}
}
