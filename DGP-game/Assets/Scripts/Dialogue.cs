using System.Collections;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI nameComponent;
    public Button buttonComponent;
    public Image skipComponent;
    public TextMeshProUGUI continueComponent;
    public string [] lines;
    public string [] names;
    public float textSpeed;
    private int i;
    private string player_name;
    private StringBuilder current_line; // stores dialogue line + player name
    private string new_current_line;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        nameComponent.text = string.Empty;
        skipComponent.gameObject.SetActive(false);
        continueComponent.gameObject.SetActive(false);
        StartDialogue();
        // Invoke("Show", 1f);
        buttonComponent.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if (textComponent.text.ToString().Equals(current_line.ToString()) && nameComponent.text == names[i]){
                NextLine();
            }
            else {
                StopAllCoroutines();
                textComponent.text = current_line.ToString();
                nameComponent.text = names[i];
            }
        }
    }

    // void Show(){
    //     laser.SetActivee(true);
    //     Invoke("Hide",3f);
    // }

    // void Hide(){
    //     laser.SetActive(false);
    // }

    void StartDialogue(){
        i=0; 
           
        player_name = PlayerPrefs.GetString("name");
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine(){
        player_name = PlayerPrefs.GetString("name");  
        current_line = new StringBuilder(lines[i].ToString(), lines[i].Length + player_name.Length);
        FindName();   // edit current line before line starts               
        foreach (char c in current_line.ToString()){                        
            textComponent.text += c;
            SetPlayerName();
            nameComponent.text = names[i];            
            yield return new WaitForSeconds(textSpeed);
        }
        yield return new WaitForSecondsRealtime(4);
        skipComponent.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
        continueComponent.gameObject.SetActive(true);

    }

    void NextLine(){
        if (i < lines.Length -1){
            i++;
            current_line = new StringBuilder(lines[i], lines[i].Length - 2 + player_name.Length);
            FindName();
            textComponent.text = string.Empty;
            nameComponent.text = string.Empty;
            skipComponent.gameObject.SetActive(false);
            continueComponent.gameObject.SetActive(false);
            StartCoroutine(TypeLine());
        } else {
            gameObject.SetActive(false);
            buttonComponent.gameObject.SetActive(true);
        }
    }

    void SetPlayerName() 
    {
        if (names[i] == "") {
            names[i]= PlayerPrefs.GetString("name");
        }
    }

    void FindName(){
        
        int j = 0; // keeps track of index
        foreach (char c in lines[i].ToCharArray()){
            if (c == '_') { // replace with character name
                current_line.Replace("_", player_name);

            }
            j++;
        }
        

//        if (c == '_') { // display character name
//                
//                foreach (char n in player_name.ToCharArray()) {
//
//                  textComponent.text += n;
//                    SetPlayerName();
//                    nameComponent.text = names[i];
//                    yield return new WaitForSeconds(textSpeed);
//                }
//            } else {   
    }
}
