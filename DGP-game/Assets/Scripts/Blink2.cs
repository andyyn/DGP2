using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Blink2 : MonoBehaviour
{
    public Color startColor = Color.green;
    public Color endColor = Color.black;
    [Range(0, 10)]
    public float speed = 1;

    TextMeshProUGUI Text;
    

    void Awake()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
        Text.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }
}
