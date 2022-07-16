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
        if(gameObject.name == "GoToScene")
        {
            GoToScene gotosceneScript = GetComponent<GoToScene>();
            gotosceneScript.RunnerScene();
        }
    }
}
