using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxSpawner : MonoBehaviour
{
    public GameObject[] newHorcrux;
    [SerializeField] HorcruxPatrol _neuePosition;
    public GameObject activateTimer;
    public Timer timer;

    private void Start()
    {
        StartCoroutine(SpawnAtStart());
        timer = activateTimer.GetComponent<Timer>();
    }
    public void SpawnNewHorcrux()
    {
        StartCoroutine(SpawnAfterTime());
    }

    IEnumerator SpawnAtStart()
    {
        yield return new WaitForSeconds(3);
        StartCoroutine(SpawnAfterTime());
    }
    IEnumerator SpawnAfterTime()
    {
        transform.position = _neuePosition.GetTargetPosition();
        yield return new WaitForSeconds(10);
        GameObject nh = Instantiate(newHorcrux[Random.Range(0, newHorcrux.Length)], this.transform) as GameObject;
        nh.transform.localPosition = new Vector3(0, 0, 0);
        StartCoroutine(DestroyAfterTime(nh));
        timer.RestartTimer();
        activateTimer.SetActive(true);
    }
    IEnumerator DestroyAfterTime(GameObject nh)
    {
        activateTimer.SetActive(false);
        yield return new WaitForSeconds(60);
        Destroy(nh);
        //Destroy Object as consequence
        StartCoroutine(SpawnAfterTime());
    }
}
