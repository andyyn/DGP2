using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameSaver : MonoBehaviour
{
    public static NameSaver FirstFirstScene;

    
    private void Awake(){
        if (FirstFirstScene == null){
            FirstFirstScene = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
}
