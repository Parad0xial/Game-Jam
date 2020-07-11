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
    private bool isGoingLeft;
    public float topSpeed;
    public float deathHeight;

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
             isGoingLeft = false;
         }
 
    if (Input.GetKey(KeyCode.A))
         {
             isGoingLeft = true;
         }
    
    if (Input.GetKeyDown("space"))
         {
             rb.velocity = new Vector2(rb.velocity.x, jumpForce);
         }

    if (isGoingLeft == false){
     rb.velocity = new Vector2(speed, rb.velocity.y);
    } else {
     rb.velocity = new Vector2(-speed, rb.velocity.y);
	}
     
     if(speed < topSpeed && hasMoved == true){
      speed = speed + speedIncrease;
	 }

     if(rb.position.y < deathHeight){
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
     
	}
}
