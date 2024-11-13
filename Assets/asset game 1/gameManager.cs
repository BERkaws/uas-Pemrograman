using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManage : MonoBehaviour
{
    public GameObject panelpausel;

    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            panelpausel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            panelpausel.SetActive(false);

        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1;
    }
    public void MenuUtama()
    {
        Application.LoadLevel(0);
    }
}
