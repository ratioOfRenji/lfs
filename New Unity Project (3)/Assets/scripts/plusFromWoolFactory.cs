using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusFromWoolFactory : MonoBehaviour
{
    public GameObject thisObject;

    private void OnMouseDown()
    {
        if (GMScript1.PopUpWoolIsActive)
        {
            GMScript1.fabric++;
            thisObject.SetActive(false);
            GMScript1.PopUpWoolIsActive = false;
        }
    }
}
