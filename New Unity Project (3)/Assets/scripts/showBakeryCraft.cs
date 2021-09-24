using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showBakeryCraft : MonoBehaviour
{
    public GameObject bakeryUi;
    public GameObject cameraDisable;




    private float lastClickTime;
    private const float DOubleClick = 0.2f;

    private void OnMouseDown()
    {

        if (gameObject.name == "пекарня")
        {
            if (Input.GetMouseButtonDown(0))
            {


                float timeSinceLastClick = Time.time - lastClickTime;

                if (timeSinceLastClick <= DOubleClick)
                {
                    GMScript1.pecarniaUiIsActive = true;
                    bakeryUi.SetActive(true);
                    cameraDisable.SetActive(false);
                }
                else
                {


                }
                lastClickTime = Time.time;
            }
        }
    }
}
