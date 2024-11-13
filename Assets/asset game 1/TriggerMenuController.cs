using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerMenuController : MonoBehaviour
{
  
    public GameObject gameOverCanvas;

    private void Start()
    {
        
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false);
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("GameOverTrigger"))
        {
            ShowGameOverMenu();
        }
    }

    
    private void ShowGameOverMenu()
    {
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }
       
        Time.timeScale = 0f;
    }
}
