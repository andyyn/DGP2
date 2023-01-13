using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SkipButtonStaircase : MonoBehaviour
{
    public Button Skip, Hint1, Hint2, Hint3, Hint0;
   
    public void DisableHint()
    {
        Skip.enabled = false; 
        Hint1.enabled = false;
        Hint2.enabled = false;
        Hint3.enabled = false;
        Hint0.enabled = false;
    }

    public void EnableHint()
    {
        Skip.enabled = true; 
        Hint1.enabled = true;
        Hint2.enabled = true;
        Hint3.enabled = true;
        Hint0.enabled = true;
    }
}
