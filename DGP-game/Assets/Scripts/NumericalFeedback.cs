using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumericalFeedback : MonoBehaviour
{
    public TextMeshProUGUI hints;
    public TextMeshProUGUI attempts;
    public TextMeshProUGUI happyFaces;
    // Start is called before the first frame update
    void Start()
    {
        hints.text = PlayerPrefs.GetInt("NL_Hint_Used").ToString();
        attempts.text = PlayerPrefs.GetInt("NL_Attempts").ToString();
        happyFaces.text = PlayerPrefs.GetInt("NL_Happy_Faces").ToString();
    }
}
