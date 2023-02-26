using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairScript : MonoBehaviour
{
    [SerializeField] BoolRepair Parent;
    private void OnTriggerStay2D(Collider2D collision)
    {
         if(collision.tag == "Player" && Input.GetKey(KeyCode.E))
         {
            //Destroy(gameObject);
            Parent.SwitchStateToRepaired();
         }
    }
}
