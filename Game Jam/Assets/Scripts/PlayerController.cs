using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

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
    public PlayerCollision pCollision;
    public Animator animator;
    private Timer timer;
    private bool dead = false;
    private ScreenShake shake;

    public Rigidbody2D rb;

    void start(){
        rb = GetComponent<Rigidbody2D>(); 
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<ScreenShake>();
	}

    void Update(){

        if (dead)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
dead = false;            
        }
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
                //shake.CamShake();
            }

        if (isGoingLeft == false && hasMoved == true){
        rb.velocity = new Vector2(speed, rb.velocity.y);
        } else if(hasMoved == true) {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        
        if(speed < topSpeed && hasMoved == true){
        speed = speed + speedIncrease;
        }
         if(rb.position.y < deathHeight){
            animator.SetBool("IsDead", true);
            timer = new Timer (new TimerCallback(TimerProc));
            timer.Change(1000,0);
            
        }
	}
    private void TimerProc(object state)
    {
        dead = true;
        Timer t = (Timer) state;
        t.Dispose();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
