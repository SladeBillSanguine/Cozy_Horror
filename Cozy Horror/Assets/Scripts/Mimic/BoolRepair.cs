using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolRepair : MonoBehaviour
{
    public bool isRepair;
    private void Start()
    {
        RandomBool();
    }

    public void RandomBool()
    {
        int randNumber = Random.Range(1, 2);
        if (randNumber == 1)
        {
            isRepair = true;
        }
        else
        {
            isRepair = false;
        }
    }
    public void ChangeBool()
    {
        isRepair = !isRepair;
    }
}
