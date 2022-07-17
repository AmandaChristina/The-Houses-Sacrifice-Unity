using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   GameObject cameraObj;
   ManagerScene managerScript;
  
    void Start()
    {
        cameraObj = GameObject.Find("Main Camera");
        managerScript = GameObject.Find("SceneManagement").GetComponent<ManagerScene>();
    }


    public void CameraMove(Transform room)
    {
        float limitX = Mathf.Clamp(room.position.x, managerScript.limitXMin, managerScript.limitXMax);
        float limitY = Mathf.Clamp(room.position.y, managerScript.limitYMin, managerScript.limitYMax);

        Vector3 newPos = new Vector3(limitX, limitY, cameraObj.transform.position.z);
        cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, newPos, Time.deltaTime * 1f);
    }
}
