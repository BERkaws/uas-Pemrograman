using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject penis;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            penis.SetActive(false);
        }
    }
}
