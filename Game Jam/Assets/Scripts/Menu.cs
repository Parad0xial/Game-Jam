using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
  public void StartGame()
  {
      Debug.Log("Started a game");
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
