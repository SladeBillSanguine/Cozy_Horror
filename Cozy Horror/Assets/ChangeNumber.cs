using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeNumber : MonoBehaviour
{
    private TMP_Text text;
    [SerializeField] public FindRepairedObject _list;
    int number;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        number = 0;
    }



    // Update is called once per frame
    void Update()
    {
        number = _list.AnzahlR();
        text.SetText(number + "/12");
        
    }
}
