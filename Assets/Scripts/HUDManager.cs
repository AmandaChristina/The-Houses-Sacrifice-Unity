using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    TMP_Text nameObj;
    TMP_Text descriptionObj;

    void Start()
    {
        nameObj = GameObject.Find("NameText").GetComponent<TMP_Text>();
        descriptionObj = GameObject.Find("DescriptionText").GetComponent<TMP_Text>();
        
    }
    public void DisplayInterative(string nameObj, string descriptionObj)
    {
        //This referência a variável global; 
        this.nameObj.text = nameObj;
        this.descriptionObj.text = descriptionObj;
    }
}
