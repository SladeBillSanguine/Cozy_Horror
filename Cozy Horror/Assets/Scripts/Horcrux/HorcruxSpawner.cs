using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxSpawner : MonoBehaviour
{
    public GameObject[] newHorcrux;
    [SerializeField] HorcruxPatrol _neuePosition;
    public void SpawnNewHorcrux()
    {
        StartCoroutine(SpawnAfterTime());
    }

    IEnumerator SpawnAfterTime()
    {
        transform.position = _neuePosition.GetTargetPosition();
        yield return new WaitForSeconds(2);
        GameObject nh = Instantiate(newHorcrux[Random.Range(0, newHorcrux.Length)], this.transform) as GameObject;
        nh.transform.localPosition = new Vector3(0, 0, 0);
    }
}
