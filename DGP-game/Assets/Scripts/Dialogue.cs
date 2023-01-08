using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI nameComponent;
    public string [] lines;
    public string [] names;
    public float textSpeed;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        nameComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if (textComponent.text == lines[i] && nameComponent.text == names[i]){
                NextLine();
            }
            else {
                StopAllCoroutines();
                textComponent.text = lines[i];
                nameComponent.text = names[i];
            }
        }
    }


    void StartDialogue(){
        i=0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine(){
        foreach (char c in lines[i].ToCharArray()){
            textComponent.text += c;
            SetPlayerName();
            nameComponent.text = names[i];
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(){
        if (i < lines.Length -1){
            i++;
            textComponent.text = string.Empty;
            nameComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else gameObject.SetActive(false);
    }

    void SetPlayerName() 
    {
        if (names[i] == "") {
            names[i]= PlayerPrefs.GetString("name");
        }
    }

}
