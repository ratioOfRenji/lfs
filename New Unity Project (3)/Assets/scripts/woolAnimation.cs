using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woolAnimation : MonoBehaviour
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
        if (sheep.woolAnimationTrigger == true)
        {
            StartCoroutine(waitBeforeStop());




        }
    }
    IEnumerator waitBeforeStop()
    {
        anim.Play("wool Animation");
        yield return new WaitForSeconds(2);
        anim.Play("wool animation idle");
        sheep.woolAnimationTrigger = false;
    }
}
