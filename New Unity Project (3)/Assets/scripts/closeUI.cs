using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUI : MonoBehaviour
{
    public GameObject thisUI;
    public GameObject cameraDisable;
    private void OnMouseDown()
    {
        thisUI.SetActive(false);
    }
    public void CloseUI ()
    {
        thisUI.SetActive(false);
        cameraDisable.SetActive(true);
    }
}
