using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strelochkaAnimation : MonoBehaviour
{

    public Animator anim;
    private bool animPlayed;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((clickStageChecker.timerToLongClick <2f) && (clickStageChecker.timerToLongClick > 0.2f))
        {
           

                anim.Play("strelochka2");
               
            


        }
        else
        {
            anim.Play("strelocka empty");
        }    
    }
   
}
