using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class bright : MonoBehaviour
{
    public RawImage badge;
    public Color brightColor = Color.green;
    public Color dullColor = Color.black;
    [Range(0, 10)]
    float count;

    void Start()
    {
        count = (float)(PlayerPrefs.GetInt("CTC_Happy_Faces") * 0.2) + 
                        (float)(PlayerPrefs.GetInt("Staircase_Happy_Faces")  * 0.1) + 
                            (float)(PlayerPrefs.GetInt("NL_Happy_Faces"));
        
        if (count > 1.4){
            badge.color = brightColor;
        }
        else {
            badge.color = dullColor;
        }
        
    }
}
