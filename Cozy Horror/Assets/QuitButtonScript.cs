using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Player leaved");
    }
}
