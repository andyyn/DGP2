using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNameReference : MonoBehaviour
{
    public static CharacterNameReference nameReference;
    public static string name2 = ReadCharacterName.returnName();
    void Update(){
        name2 = ReadCharacterName.returnName();
    }


    private void Awake(){
        if (nameReference == null){
            nameReference = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    public static string giveName(){
        return name2;
    }
}
