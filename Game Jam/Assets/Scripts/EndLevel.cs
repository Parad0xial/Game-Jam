using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.tag == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
