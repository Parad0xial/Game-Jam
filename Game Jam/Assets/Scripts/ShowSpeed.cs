using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class ShowSpeed : MonoBehaviour
{
    public Text speed;
    public GameObject player;
    // Update is called once per frame
    void Update()
    { 
        PlayerController playerScript = player.GetComponent<PlayerController>(); 
        float speedTemp = Mathf.Floor(playerScript.speed);
        speed.text = "SPEED: " + speedTemp.ToString();
        
    }
}
