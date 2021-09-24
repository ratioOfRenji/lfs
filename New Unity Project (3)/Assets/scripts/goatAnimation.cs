using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goatAnimation : MonoBehaviour
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
        if (goat.animationTrigger == true)
        {
            StartCoroutine(waitBeforeStop());




        }
    }
    IEnumerator waitBeforeStop()
    {
        anim.Play("goatMilkAnimation");
        yield return new WaitForSeconds(2);
        anim.Play("goatTransparent");
        goat.animationTrigger = false;
    }
}
