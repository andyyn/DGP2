using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UnlockPower : MonoBehaviour
{
    public TextMeshProUGUI happy_face_display;
    public float count_speed;
    private int count;
    private int counting;
    // Start is called before the first frame update
    void Start()
    {
        count = PlayerPrefs.GetInt("NL_Happy_Faces") +
                PlayerPrefs.GetInt("CTC_Happy_Faces") +
                PlayerPrefs.GetInt("Staircase_Happy_Faces");
               
        counting = 0;
        StartCoroutine(UpdateText());
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (counting != count) {
        //    happy_face_display.text = counting.ToString();
        //}
    }

    IEnumerator UpdateText(){
        for(int i = 0; i<=count; i++){
            happy_face_display.text = i.ToString();
            counting++;
            yield return new WaitForSeconds(count_speed);
        }
    }
}
