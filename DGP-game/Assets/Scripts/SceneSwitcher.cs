using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private float count;

    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Tab1(){
        SceneManager.LoadSceneAsync("Progress2");
    }

    public void Tab2(){
        SceneManager.LoadSceneAsync("Progress 1");
    }

    public void Change2Prog1(){
        count = (float)(PlayerPrefs.GetInt("CTC_Happy_Faces") * 0.2) + 
                        (float)(PlayerPrefs.GetInt("Staircase_Happy_Faces")  * 0.1) + 
                            (float)(PlayerPrefs.GetInt("NL_Happy_Faces"));

        if (count < 1.5){
            SceneManager.LoadSceneAsync("Progress 1");
        }
        else {
            SceneManager.LoadSceneAsync("Level Up");
        }
    }
}
