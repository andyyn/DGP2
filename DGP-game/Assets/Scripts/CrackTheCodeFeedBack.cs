using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CrackTheCodeFeedBack : MonoBehaviour
{
    public TextMeshProUGUI hints;
    public TextMeshProUGUI attempts;
    public TextMeshProUGUI happyFaces;
    // Start is called before the first frame update
    void Start()
    {
        hints.text = PlayerPrefs.GetInt("CTC_Hint_Used").ToString();
        attempts.text = PlayerPrefs.GetInt("CTC_Attempts").ToString();
        happyFaces.text = PlayerPrefs.GetInt("CTC_Happy_Faces").ToString();
    }
}
