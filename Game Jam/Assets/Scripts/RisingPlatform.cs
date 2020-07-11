
using UnityEngine;

public class RisingPlatform : MonoBehaviour
{

    public Rigidbody2D rb;
    public float risingspeed;

    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.tag == "Player"){
          rb.velocity = new Vector2(risingspeed, rb.velocity.x);
          }
        }

}
