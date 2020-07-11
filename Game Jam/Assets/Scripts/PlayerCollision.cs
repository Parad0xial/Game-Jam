using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public Animator animator;
    private Collision2D col;
    public PlayerController movement;

    void Start()
    {
        StartCoroutine(OnCollisionEnter2D(col));
    }

    public IEnumerator OnCollisionEnter2D(Collision2D col){
        if(col.collider.tag == "Obstacle"){
            animator.SetBool("IsDead", true);
            yield return new WaitForSeconds(.44f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
