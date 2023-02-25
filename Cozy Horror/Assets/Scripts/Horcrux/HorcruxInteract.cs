using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxInteract : MonoBehaviour
{
    public void OnMouseDown()
    {
        GameObject.Find("HorcruxSpawner").GetComponent<HorcruxSpawner>().SpawnNewHorcrux();
        GameObject.Find("Game Manager").SetActive(false);
        Destroy(this.gameObject);
    }
}
