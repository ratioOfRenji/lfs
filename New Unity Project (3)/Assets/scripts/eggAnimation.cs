using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggAnimation : MonoBehaviour
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
        if (hen.animationTrigger == true)
        {
            StartCoroutine(waitBeforeStop());




        }
    }
    IEnumerator waitBeforeStop()
    {
        anim.Play("eggAnimation");
        yield return new WaitForSeconds(2);
        anim.Play("eggTransparent");
        hen.animationTrigger = false;
    }
}
