using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float horizontalVelocity;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
            print("horizontalVelocity:" + horizontalVelocity +
                ";Time.deltaTime:" + Time.deltaTime + ">>x:"
                + horizontalVelocity * Time.deltaTime);
            this.GetComponent<Rigidbody>().velocity =
            new Vector3(horizontalVelocity * Time.deltaTime,
            this.GetComponent<Rigidbody>().velocity.y,
            this.GetComponent<Rigidbody>().velocity.z);
        }

    }
    private void OnTriggerEnter(Collider c)
    {
       if(c.gameObject.GetComponent<obstacleContrller>() != null)
        {
            GameObject.Destroy(this.gameObject);
        }
      
    }
}
