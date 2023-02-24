using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxSpawner : MonoBehaviour
{
    public GameObject[] newHorcrux;
    
    public void SpawnNewHorcrux()
    {
        StartCoroutine(SpawnAfterTime());
    }

    IEnumerator SpawnAfterTime()
    {
        yield return new WaitForSeconds(5);
        GameObject nh = Instantiate(newHorcrux[Random.Range(0, newHorcrux.Length)], this.transform) as GameObject;
        nh.transform.localPosition = new Vector3(0, 0, 0);
    }
}
