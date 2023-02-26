using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolRepair : MonoBehaviour
{
    public bool isRepair;
    [SerializeField] GameObject repairedObject;
    [SerializeField] GameObject brokenObject;
    private void Start()
    {
        RandomBool();
        if (isRepair)
        {
            this.SwitchStateToRepaired();
        }
        else
        {
            this.SwitchStateToBroken();
        }
        ChangeBool();
    }

    public void RandomBool()
    {
        /*int randNumber = Random.Range(1, 2);
        if (randNumber == 1)
        {
            isRepair = true;
        }
        else
        {
            isRepair = false;
        }*/
        isRepair = false;
    }
    public void ChangeBool()
    {
        isRepair = !isRepair;
    }

    public bool getBool()
    {
        return isRepair;
    }

    public void SwitchStateToBroken()
    {
        repairedObject.SetActive(false);
        brokenObject.SetActive(true);
        ChangeBool();
    }

    public void SwitchStateToRepaired()
    {
        repairedObject.SetActive(true);
        brokenObject.SetActive(false);
        ChangeBool();
    }

}
