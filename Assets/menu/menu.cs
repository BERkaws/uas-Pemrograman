using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject infopanel;

    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startbutton(string mulai)
    {
        SceneManager.LoadScene(mulai);
    }
    public void main(string satu)
    {
        SceneManager.LoadScene(satu);
    }
    public void infobutton()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(true);
    }
    public void backbutton()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }
    public void Quitbutton()
    {
        Application.Quit();
    }
}
