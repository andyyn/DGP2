using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HintStaircaseGame : MonoBehaviour
{
   
    private int happy_faces = 3;
    private int attempts = 0;
    private int hintsUsed = 0;
    public Button hint1, hint2, hint3, hint0, submit;
    public TMP_InputField user_Answer;
    public GameObject Hint1P, Hint2P, Hint3P, WrongAnsP, CorrectAnsP, QuesP, HintsP;


    // Start is called before the first frame update
    void Start()
    {
        hint1.onClick.AddListener(Hint1Active);
        hint2.onClick.AddListener(Hint2Active);
        hint3.onClick.AddListener(Hint3Active);
        submit.onClick.AddListener(Check_Answer);
        happy_faces = 3;
        attempts = 0;
        hintsUsed = 0;
        
    }

    void Update_Happy_Faces()
    {
        if (happy_faces > 0)
        {
            happy_faces-=1;
        }
        PlayerPrefs.SetInt("Staircase_Happy_Faces", happy_faces);
        Debug.Log("Happy Face Count:" + happy_faces);
    }
    void Hint1Active()
    {
        hintsUsed +=1;
        PlayerPrefs.SetInt("Staircase_Hint_Used", hintsUsed);
        Hint1P.SetActive(true);
        Hint2P.SetActive(false);
        Hint3P.SetActive(false);
        
        Update_Happy_Faces();
    }

    void Hint2Active()
    {
        hintsUsed +=1;
        PlayerPrefs.SetInt("Staircase_Hint_Used", hintsUsed);
        Hint1P.SetActive(false);
        Hint2P.SetActive(true);
        Hint3P.SetActive(false);

        Update_Happy_Faces();
    }

    void Hint3Active()
    {
        hintsUsed +=1;
        PlayerPrefs.SetInt("Staircase_Hint_Used", hintsUsed);
        Hint1P.SetActive(false);
        Hint2P.SetActive(false);
        Hint3P.SetActive(true);
        Update_Happy_Faces();
    }

    void Check_Answer()
    {
        // Answer empty
        if (user_Answer.text == "")
        {
            Debug.Log("Enter a number");
        }

        // Answer correct
        else if (user_Answer.text == "64" || user_Answer.text == " 64" || user_Answer.text == "64 ")
        {
            attempts += 1;
            // Save game progress
            PlayerPrefs.SetInt("Staircase_Happy_Faces", happy_faces);
            PlayerPrefs.SetInt("Staircase_Attempts", attempts);
            PlayerPrefs.SetInt("Staircase_Hint_Used", hintsUsed);
            CorrectAnsP.SetActive(true);
            HintsP.SetActive(false);
            QuesP.SetActive(false);
            Debug.Log("Correct Answer!");
        }
        // Answer wrong
        else{
            attempts += 1;
            PlayerPrefs.SetInt("Staircase_Attempts", attempts);
            Update_Happy_Faces();
            WrongAnsP.SetActive(true);
            QuesP.SetActive(false);
            Debug.Log("Wrong! Try Again!");

        }

    
    }
    

    
}
