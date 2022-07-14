using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
   public TMP_Text nameObj;
   public TMP_Text descriptionObj;

    
    public void DisplayInterative(string nameObj, string descriptionObj)
    {
        //This refer�ncia a vari�vel global; 
        this.nameObj.text = nameObj;
        this.descriptionObj.text = descriptionObj;
    }
}
