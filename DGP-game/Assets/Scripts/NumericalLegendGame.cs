using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumericalLegendGame : MonoBehaviour
{

    private int happy_faces = 5;
    private int attempts = 0;
    private int hintsUsed = 0;
    public Button hint1, hint2, hint3, hint0, submit;
    public TMP_InputField user_Answer_Min;
    public TMP_InputField user_Answer_Max;
    public GameObject Hint1P, Hint2P, Hint3P, WrongAnsP, CorrectAnsP, QuesP, HintsP;

    public AudioSource source;
    public AudioClip clip; 


    // Start is called before the first frame update
    void Start()
    {
        hint1.onClick.AddListener(Hint1Active);
        hint2.onClick.AddListener(Hint2Active);
        hint3.onClick.AddListener(Hint3Active);
        submit.onClick.AddListener(Check_Answer);
        happy_faces = 5;
        attempts = 0;
        hintsUsed = 0;
        // if not played then keep 0
        PlayerPrefs.SetInt("NL_Happy_Faces", 0);
        PlayerPrefs.SetInt("NL_Hint_Used",0);
        PlayerPrefs.SetInt("NL_Attempts",0);

    }

    void Update_Happy_Faces()
    {
        if (happy_faces > 1)
        {
            happy_faces -= 1;
        }
        PlayerPrefs.SetInt("NL_Happy_Faces", happy_faces);
        Debug.Log("Happy Face Count:" + happy_faces);
    }
    void Hint1Active()
    {
        hintsUsed += 1;
        PlayerPrefs.SetInt("NL_Hint_Used", hintsUsed);
        Hint1P.SetActive(true);
        Hint2P.SetActive(false);
        Hint3P.SetActive(false);

        Update_Happy_Faces();
    }

    void Hint2Active()
    {
        hintsUsed += 1;
        PlayerPrefs.SetInt("NL_Hint_Used", hintsUsed);
        Hint1P.SetActive(false);
        Hint2P.SetActive(true);
        Hint3P.SetActive(false);

        Update_Happy_Faces();
    }

    void Hint3Active()
    {
        hintsUsed += 1;
        PlayerPrefs.SetInt("NL_Hint_Used", hintsUsed);
        Hint1P.SetActive(false);
        Hint2P.SetActive(false);
        Hint3P.SetActive(true);
        Update_Happy_Faces();
    }

    void Check_Answer()
    {
        // Answer empty
        if (user_Answer_Min.text == "" || user_Answer_Max.text == "")
        {
            Debug.Log("Enter a number");
        }

        // Answer correct
        else if (user_Answer_Min.text == "12" && user_Answer_Max.text == "24")
        {
            attempts += 1;
            // Save game progress
            PlayerPrefs.SetInt("NL_Happy_Faces", happy_faces);
            PlayerPrefs.SetInt("NL_Attempts", attempts);
            PlayerPrefs.SetInt("NL_Hint_Used", hintsUsed);
            CorrectAnsP.SetActive(true);
            HintsP.SetActive(false);
            QuesP.SetActive(false);

            source.PlayOneShot(clip);
            Debug.Log("Correct Answer!");
        }
        // Answer wrong
        else
        {
            attempts += 1;
            PlayerPrefs.SetInt("NL_Attempts", attempts);
            Update_Happy_Faces();
            WrongAnsP.SetActive(true);
            QuesP.SetActive(false);
            Debug.Log("Wrong! Try Again!");

        }


    }



}
