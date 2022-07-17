using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
   [SerializeField]
   GameObject playerObj,canvasObj;
   [SerializeField]
   public float limitXMin, limitYMin, limitXMax, limitYMax;

    void Awake()
    {
        StartCoroutine(CreateObj());
    }

     IEnumerator CreateObj()
    {
        Instantiate(canvasObj);
        yield return new WaitForSeconds(0.2f);
        Instantiate(playerObj);
    }

    

   
}
