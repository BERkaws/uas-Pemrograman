using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
   public void restart()
    {
        SceneManager.LoadScene("samplescene");
    }
}
