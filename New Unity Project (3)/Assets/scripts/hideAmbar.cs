using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideAmbar : MonoBehaviour
{
    public GameObject ambarUi;
    public GameObject bakeryUi;
    public GameObject cameraDisable;
    public void hideAmbarUI()
    {
        ambarUi.SetActive(false);
    }
    public void hideBakeryUI()
    {
        bakeryUi.SetActive(false);
        cameraDisable.SetActive(true);
        GMScript1.pecarniaUiIsActive = false;
    }
}
