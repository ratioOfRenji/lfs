using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeWoolFabric : MonoBehaviour
{

    public GameObject woolFabric;
    public GameObject applyButton;
    public Transform teleportTargetSlot1;
    public GameObject cameraDisable;
    private void Update()
    {
        if ((GMScript1.sewSlot1) && (GMScript1.sewSlot2))
        {

            woolFabric.SetActive(true);

            applyButton.SetActive(true);

        }
        cameraDisable.SetActive(false);
    }
}
