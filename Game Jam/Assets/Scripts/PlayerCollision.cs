using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.tag == "Obstacle"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
