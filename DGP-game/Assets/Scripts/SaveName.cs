using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SaveName : MonoBehaviour
{
    public TMP_InputField textBox;

    public void clickSaveButton() 
    {
        PlayerPrefs.SetString("name", textBox.text);
        Debug.Log("Name :" + PlayerPrefs.GetString("name"));
        SceneManager.LoadSceneAsync("Scene 1");
    }
    
    
}
