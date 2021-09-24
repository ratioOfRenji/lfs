using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkAnimation : MonoBehaviour
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
        if (cow.animationTrigger == true)
        {
            StartCoroutine(waitBeforeStop());




        }
    }
    IEnumerator waitBeforeStop()
    {
        anim.Play("milkAnimation");
        yield return new WaitForSeconds(2);
        anim.Play("milkTransparent");
        cow.animationTrigger = false;
    }
}
