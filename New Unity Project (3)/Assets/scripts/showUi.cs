using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUi : MonoBehaviour
{
    public GameObject Ui;
    public GameObject cameraDisable;



    private float lastClickTime;
    private const float DOubleClick = 0.2f;
    public static bool uiIsActive;
    private void OnMouseDown()
    {

       
        
            if (Input.GetMouseButtonDown(0))
            {


                float timeSinceLastClick = Time.time - lastClickTime;

                if (timeSinceLastClick <= DOubleClick)
                {
                   uiIsActive = true;
                    Ui.SetActive(true);
               
                    
                 
                }
                else
                {


                }
                lastClickTime = Time.time;
            }
        
    }
    
    private void Update()
    {
        if (uiIsActive)
        {
            cameraDisable.SetActive(false);
        }
        if(Ui.activeInHierarchy == false)
        {
           // uiIsActive = false;
        }
    }
    public void _showUI()
    {
        Ui.SetActive(true);
        
    }
}
