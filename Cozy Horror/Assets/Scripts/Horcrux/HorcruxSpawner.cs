using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxSpawner : MonoBehaviour
{
    public GameObject[] newHorcrux;
    [SerializeField] HorcruxPatrol _neuePosition;

    private void Start()
    {
        StartCoroutine(SpawnAtStart());
    }
    public void SpawnNewHorcrux()
    {
        StartCoroutine(SpawnAfterTime());
    }

    IEnumerator SpawnAtStart()
    {
        yield return new WaitForSeconds(30);
        StartCoroutine(SpawnAfterTime());
    }
    IEnumerator SpawnAfterTime()
    {
        transform.position = _neuePosition.GetTargetPosition();
        yield return new WaitForSeconds(30);
        GameObject nh = Instantiate(newHorcrux[Random.Range(0, newHorcrux.Length)], this.transform) as GameObject;
        nh.transform.localPosition = new Vector3(0, 0, 0);
        StartCoroutine(DestroyAfterTime(nh));
    }
    IEnumerator DestroyAfterTime(GameObject nh)
    {
        //Add Timer 60 seconds, to find the mimic, here
        yield return new WaitForSeconds(60);
        Destroy(nh);
        StartCoroutine(SpawnAfterTime());
    }
}
