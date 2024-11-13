using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    private int count;
    public Text counttext;
    public Text wintext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("poin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            

        }
    }
}
