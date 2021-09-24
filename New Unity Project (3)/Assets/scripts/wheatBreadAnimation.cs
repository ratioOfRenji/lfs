using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheatBreadAnimation : MonoBehaviour
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
        if(plusFromBakery.wheatBreadAnimationTrigger == true)
        {
            StartCoroutine(waitBeforeStop());
           
            
                
            
        }
    }
    IEnumerator waitBeforeStop()
    {
        anim.Play("bread Animation");
        yield return new WaitForSeconds(1);
        anim.Play("New State");
        plusFromBakery.wheatBreadAnimationTrigger = false;
    }
}
