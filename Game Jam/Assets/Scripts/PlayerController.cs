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
     rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
     
     speed = speed + speedIncrease;
	}
}
