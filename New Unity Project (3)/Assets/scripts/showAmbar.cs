using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showAmbar : MonoBehaviour
{
    public GameObject ambarUi;

  

    private float lastClickTime;
    private const float DOubleClick = 0.2f;

    private void OnMouseDown()
    {
        
        //if (gameObject.name == "амбар")
        //{
            if (Input.GetMouseButtonDown(0))
            {


                float timeSinceLastClick = Time.time - lastClickTime;

                if (timeSinceLastClick <= DOubleClick)
                {
                    
                    ambarUi.SetActive(true);
                }
                else
                {

                    
                }
                lastClickTime = Time.time;
            }
        //}
    }
}

   
       

