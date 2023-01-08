using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputName : MonoBehaviour
{
    public static InputName scene1;
    public TMP_InputField inputField;

    public string player_name;

    // singleton
    private void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName()
    {
        player_name = inputField.text;

        SceneManager.LoadSceneAsync("Scene2");
    }
}


