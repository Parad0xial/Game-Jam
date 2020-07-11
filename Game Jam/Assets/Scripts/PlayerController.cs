using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speedIncrease;
    public float speed;
    public float jumpForce;
    private float moveInput;
    private bool hasMoved;

    public Rigidbody2D rb;

    void start(){
     rb = GetComponent<Rigidbody2D>(); 
	}

    void Update(){
     moveInput = Input.GetAxisRaw("Horizontal");

     if (moveInput > 0){
      hasMoved = true;
	 }

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
     
     if(speed < 50 && hasMoved == true){
      speed = speed + speedIncrease;
	 }

     if(rb.position.y < -50){
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
     
	}
}
