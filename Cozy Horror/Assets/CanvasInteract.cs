using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasInteract : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            Destroy(this.gameObject);
        }
    }
}
