using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakeryAnimation : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(wheatBreadTimer.startTiimer == true)
        {
            anim.Play("bakery cook Animation2");
        }
       if (wheatBreadTimer.startTiimer == false)
        {
            anim.Play("bakery idle Animation");
        }
    }
}
