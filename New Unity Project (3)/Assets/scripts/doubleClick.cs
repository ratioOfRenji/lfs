using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doubleClick : MonoBehaviour
{
    private float lastClickTime;
    private const float DOubleClick = 0.2f;
    

    
   private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           

            float timeSinceLastClick = Time.time - lastClickTime;
            
            if(timeSinceLastClick <= DOubleClick)
            {
                Debug.Log("yea");
            }
            else
            {

                Debug.Log("nope");
            }
            lastClickTime = Time.time;
        }
    }
}
