using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Death());
    }
        void Death(){ 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
}
