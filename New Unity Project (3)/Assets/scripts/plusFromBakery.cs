using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusFromBakery : MonoBehaviour
{
    public GameObject thisObject;
    public static bool wheatBreadAnimationTrigger;
    private void OnMouseDown()
    {
        if (GMScript1.bakeryPopUpIsActive)
        {
            GMScript1.wheatBread++;
            thisObject.SetActive(false);
            GMScript1.bakeryPopUpIsActive = false;
            wheatBreadAnimationTrigger = true;
           
        }
    }
}
