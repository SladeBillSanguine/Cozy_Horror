using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRepairedObject : MonoBehaviour
{

    List<GameObject> _targets;
    GameObject[] _objects;

    /* private void Awake()
     {
         GameObject[] myElements = GetComponentsInChildren<GameObject>();
         _targets = new List<GameObject>();
         _targets.AddRange(myElements);
         _targets.RemoveAt(0);
     }*/

    private void Awake()
    {
        _objects = GetComponentsInChildren<GameObject>();
    }

    public void Finde()
    {
        int randNumber = Random.Range(1, 2);
    }

}
