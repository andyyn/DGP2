using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider ReasonM, ProblemS, NumL, SharpT, MindR; // sliders
    public ParticleSystem nl, ps, st, rm, mr;
    public float fill_speed = 5f;
    private float progRM = 0, progPS = 0, progNL = 0, progST = 0, progMR = 0;


    // Start is called before the first frame update
    void Start()
    {
        IncrementProg();
    }

    // Update is called once per frame
    void Update()
    {   // increments progress bar for a slider
        if (ReasonM.value < progRM) {
            ReasonM.value += fill_speed * Time.deltaTime;
            if (!rm.isPlaying) {
                rm.Play();
            }

        }  else {
            rm.Stop();
        }

        if (ProblemS.value < progPS) {
            ProblemS.value += fill_speed * Time.deltaTime;
            if (!ps.isPlaying) {
                ps.Play();
            }
        } else {
            ps.Stop();
        }

        if (NumL.value < progNL) {
            NumL.value += fill_speed * Time.deltaTime;
            if (!nl.isPlaying) {
                nl.Play();
            }
        } else {
            nl.Stop();
        }

        if (SharpT.value < progST) {
            SharpT.value += fill_speed * Time.deltaTime;
            if (!st.isPlaying) {
                st.Play();
            }
        } else {
            st.Stop();
        }

        if (MindR.value < progMR) {
            MindR.value += fill_speed * Time.deltaTime;
            if (!mr.isPlaying) {
                mr.Play();
            }
        } else {
            mr.Stop();
        }

        
    }

    public void IncrementProg() {
        progRM = calRM();
        progPS = calPS();
        progNL = calNL();
        progST = calST();
        progMR = calMR();
    }

    // Calculations:
    // Reasoning Master from puzzle 1 & 2
    float calRM() {
        float score1 = (float)(PlayerPrefs.GetInt("CTC_Happy_Faces") * 0.4) + 
                        (float)(PlayerPrefs.GetInt("Staircase_Happy_Faces")  * 0.4);
        Debug.Log("Score1:" + score1);
        return score1;
    }

    // Problem Solver from Puzzle 1
    float calPS() {
        float score2 = (float)(PlayerPrefs.GetInt("CTC_Happy_Faces") * 0.3);
        Debug.Log("Score2:" + score2);
        return score2;
        
    }

    //  Numerical Legend from Puzzle 1, 2, & 3
    float calNL() {
        float score3 = (float)(PlayerPrefs.GetInt("CTC_Happy_Faces") * 0.2) + 
                        (float)(PlayerPrefs.GetInt("Staircase_Happy_Faces")  * 0.1) + 
                                                                        3; // get from 3rd puzzle
        Debug.Log("Score3:" + score3);
        return score3;
    }

    // Sharp Thinker from Puzzle 1 & 2
    float calST() {
        float score4 = (float)(PlayerPrefs.GetInt("CTC_Happy_Faces") * 0.1) + 
                        (float)(PlayerPrefs.GetInt("Staircase_Happy_Faces")  * 0.3);
        Debug.Log("Score4:" + score4);
        return score4;
    }

    // Mind Reader from Puzzle 2
    float calMR() {
        float score5 = (float)(PlayerPrefs.GetInt("Staircase_Happy_Faces") * 0.2);
        Debug.Log("Score5:" + score5);
        return score5;
    }
}
