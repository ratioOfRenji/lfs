using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeWheatBread : MonoBehaviour
{
    public GameObject wheatBread;
    public GameObject applyButton;
    public Transform teleportTargetSlot1;
    public GameObject cameraDisable;
    
    private void Update()
    {
        if((GMScript1.pecarnyaSlot1 ) &&(GMScript1.pecarnyaSlot2 ))
        {

            wheatBread.SetActive(true);

            applyButton.SetActive(true);

           

        }
        cameraDisable.SetActive(false);
    }
}
