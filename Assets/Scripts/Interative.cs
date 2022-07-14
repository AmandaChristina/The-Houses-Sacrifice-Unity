using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interative : MonoBehaviour
{
    public string descriptionObj, nameObj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ExecuteInterative()
    {
        if(this.nameObj == "Door")
        {
            Door doorScript = GetComponent<Door>();
            doorScript.RunnerScene();
        }
    }
}
