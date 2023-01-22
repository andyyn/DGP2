using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StudyPopUp : MonoBehaviour
{
    public Button Study1, Study2, Study3, Study4, Study5, Study6, Study7, Study8, Study9, Study10, Study11, Study12, Study13, Study14, Study15;
    public Button Close1, Close2, Close3, Close4, Close5, Close6, Close7, Close8, Close9, Close10, Close11, Close12, Close13, Close14, Close15;
    public GameObject Info1P, Info2P, Info3P, Info4P, Info5P, Info6P, Info7P, Info8P, Info9P, Info10P, Info11P, Info12P, Info13P, Info14P, Info15P;
    public float moveSpeed;
    private int initial_position = 0; // initial y pos
    private int final_position = 530; // final y pos
    //private GameObject pre =Info1P; // previous button clicked
    private int i;
    private GameObject curr; // current button clicked

    // Start is called before the first frame update
        void Start()
        {
            i = 0;
            curr = new GameObject ();
            //Info1P.transform.position.y = -949.57f;
            //final_position = new Vector3(-6f, -849.57f, 0);
           // Debug.Log(final_position);
            Study1.onClick.AddListener(B1);
            Close1.onClick.AddListener(disable);

            Study2.onClick.AddListener(B2);
            Close2.onClick.AddListener(disable);

            Study3.onClick.AddListener(B3);
            Close3.onClick.AddListener(disable);

            Study4.onClick.AddListener(B4);
            Close4.onClick.AddListener(disable);

            Study5.onClick.AddListener(B5);
            Close5.onClick.AddListener(disable);

            Study6.onClick.AddListener(B6);
            Close6.onClick.AddListener(disable);

            Study7.onClick.AddListener(B7);
            Close7.onClick.AddListener(disable);

            Study8.onClick.AddListener(B8);
            Close8.onClick.AddListener(disable);

            Study9.onClick.AddListener(B9);
            Close9.onClick.AddListener(disable);

            Study10.onClick.AddListener(B10);
            Close10.onClick.AddListener(disable);

            Study11.onClick.AddListener(B11);
            Close11.onClick.AddListener(disable);

            Study12.onClick.AddListener(B12);
            Close12.onClick.AddListener(disable);

            Study13.onClick.AddListener(B13);
            Close13.onClick.AddListener(disable);

            Study14.onClick.AddListener(B14);
            Close14.onClick.AddListener(disable);

            Study15.onClick.AddListener(B15);
            Close15.onClick.AddListener(disable);
        }

        // button 1
        void B1(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info1P.SetActive(true);
            curr = Info1P; // set new curr
            StartC(); // move up
        }

        void B2(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info2P.SetActive(true);
            curr = Info2P; // set new curr
            StartC(); // move up
        }

        void B3(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info3P.SetActive(true);
            curr = Info3P; // set new curr
            StartC(); // move up
        }

        void B4(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info4P.SetActive(true);
            curr = Info4P; // set new curr
            StartC(); // move up
        }

        void B5(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info5P.SetActive(true);
            curr = Info5P; // set new curr
            StartC(); // move up
        }

        void B6(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info6P.SetActive(true);
            curr = Info6P; // set new curr
            StartC(); // move up
        }

        void B7(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info7P.SetActive(true);
            curr = Info7P; // set new curr
            StartC(); // move up
        }

        void B8(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info8P.SetActive(true);
            curr = Info8P; // set new curr
            StartC(); // move up
        }

        void B9(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info9P.SetActive(true);
            curr = Info9P; // set new curr
            StartC(); // move up
        }

        void B10(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info10P.SetActive(true);
            curr = Info10P; // set new curr
            StartC(); // move up
        }

        void B11(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info11P.SetActive(true);
            curr = Info11P; // set new curr
            StartC(); // move up
        }

        void B12(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info12P.SetActive(true);
            curr = Info12P; // set new curr
            StartC(); // move up
        }

        void B13(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info13P.SetActive(true);
            curr = Info13P; // set new curr
            StartC(); // move up
        }

        void B14(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info14P.SetActive(true);
            curr = Info14P; // set new curr
            StartC(); // move up
        }

        void B15(){
            if (i!=0){
                disable(); // disable curr
            }
            i+=1; // pop-up is on screen
            Info15P.SetActive(true);
            curr = Info15P; // set new curr
            StartC(); // move up
        }
    
    public void StartC(){
        StartCoroutine(PopUp());
    }

    IEnumerator PopUp(){
        //Vector3 initial_position = Info1P.transform.position;
        initial_position = 0;
        while(initial_position < final_position){
            curr.transform.position = curr.transform.position + new Vector3(0,10,0);
            initial_position += 10;

            yield return new WaitForSeconds(moveSpeed);
        }
        //pre = curr; // set to pre and get new curr
        
    }
    // Pop down
    void disable(){
        curr.SetActive(false); // close clicked or other button clicked so hide current onscreen
        curr.transform.position = curr.transform.position + new Vector3(0,-530,0); // return to old position
        i = 0; // no pop-up to disable- pop up off screen
    }
}
