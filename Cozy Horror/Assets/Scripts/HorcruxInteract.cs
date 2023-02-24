using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxInteract : MonoBehaviour
{
    public void OnMouseDown()
    {
        GameObject.Find("HorcruxSpawner").GetComponent<HorcruxSpawner>().SpawnNewHorcrux();
        Destroy(this.gameObject);
    }
}
