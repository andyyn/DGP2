using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadCharacterName : MonoBehaviour
{
    static string input = "Andy";

    public void ReadName(string name){
        input = name;
    }

    public static string returnName(){
        return input;
    }
}
