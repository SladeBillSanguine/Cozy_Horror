using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxSpawner : MonoBehaviour
{
    public GameObject[] newHorcrux;
    [SerializeField] HorcruxPatrol _neuePosition;
    [SerializeField] FindRepairedObject _brokeScript;
    public GameObject activateTimer;
    private Timer timer;

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
        
        yield return new WaitForSeconds(60);
        activateTimer.SetActive(false);
        Destroy(nh);
        //Destroy Object as consequence
        _brokeScript.changeState();
        StartCoroutine(SpawnAfterTime());
        
    }
}
