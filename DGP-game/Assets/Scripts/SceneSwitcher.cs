using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

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

   /* void Update()
    { 
        if (SceneManager.GetActiveScene().name == "Scene 2.2")
        {
            BGMusic.instance.GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "Scene 4.1")
        {
            BGMusic.instance.GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "Scene 5.2")
        {
            BGMusic.instance.GetComponent<AudioSource>().Pause();
        }
    }*/
}
