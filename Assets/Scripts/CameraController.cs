using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject cameraObj;
    //1 = up
    //2 = down
    //3 = right
    //4 = left
    [SerializeField]
    int lado;

    void Start()
    {
        cameraObj = GameObject.Find("Main Camera");
    }


    void Update()
    {
        
    }

    public void CameraMove()
    {
        Vector3 posCamera = cameraObj.transform.position;

        if (this.lado == 1) { posCamera = Vector3.Lerp(posCamera, posCamera + Vector3.up*2, 3f); }
        else if (this.lado == 2) { }
        else if (this.lado == 3) { }
        else if (this.lado == 4) { }
    }
}
