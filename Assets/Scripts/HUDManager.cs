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
        //This referência a variável global; 
        this.nameObj.text = nameObj;
        this.descriptionObj.text = descriptionObj;
    }
}
