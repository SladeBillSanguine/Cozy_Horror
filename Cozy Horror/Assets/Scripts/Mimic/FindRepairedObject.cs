using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRepairedObject : MonoBehaviour
{

    List<GameObject> _targets;
    BoolRepair[] _objects;
    bool _isRepaired;
    bool _found;
    int randNumber;

    /* private void Awake()
     {
         GameObject[] myElements = GetComponentsInChildren<GameObject>();
         _targets = new List<GameObject>();
         _targets.AddRange(myElements);
         _targets.RemoveAt(0);
     }*/

    private void Awake()
    {
        _objects = this.GetComponentsInChildren<BoolRepair>();
    }

    public void Finde()
    {
        randNumber = Random.Range(0, _objects.Length);
        _isRepaired = _objects[randNumber].getBool();

        if (_isRepaired)
        {
            _found = true;
        }else{
            _found = false;
        }
    }

    

    public void changeState()
    {
        do {
            Finde();
        }
        while (!_found);
        _objects[randNumber].SwitchStateToBroken();

    }

}
