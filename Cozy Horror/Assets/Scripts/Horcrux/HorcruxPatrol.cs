using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorcruxPatrol : MonoBehaviour
{

    List<Transform> _targets;

    private void Awake()
    {
        Transform[] myElements = transform.GetComponentsInChildren<Transform>();
        _targets = new List<Transform>();
        _targets.AddRange(myElements);
        _targets.RemoveAt(0);
    }
    public Vector2 GetTargetPosition()
    {
        Transform randomPos = getRandomTarget();
        return randomPos.position;
    }
    public Transform getRandomTarget()
    {
        int randValue = Random.Range(0, _targets.Count);
        Transform newTransform = _targets[randValue];
        return newTransform;
    }
}