using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.tag == "Player")
        {
            Debug.Log("ins");
            if (Input.GetKeyDown(KeyCode.E))
            {
            Debug.Log("funk"); 
            Destroy(gameObject);
            }
        }
    }
}
