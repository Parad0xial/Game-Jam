
using UnityEngine;

public class RisingPlatform : MonoBehaviour
{

    public Vector3 velocity; 
    private bool moving = false;
    public bool moveWithPlatform = false;

    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.tag == "Player"){
          moving = true;
        if(moveWithPlatform){
            col.collider.transform.SetParent(transform);
            }
          }
        }
    void OnCollisionExit2D(Collision2D col){
        if(col.collider.tag == "Player"){
          moving = false;
          if(moveWithPlatform){
            col.collider.transform.SetParent(transform);
            }
          }
        }
    void FixedUpdate(){
        if(moving){
            transform.position += (velocity * Time.deltaTime);
        }
    }

}
