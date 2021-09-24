using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showWoolCraft : MonoBehaviour
{
    public GameObject woolUi;
    public GameObject cameraDisable;



    private float lastClickTime;
    private const float DOubleClick = 0.2f;

    private void OnMouseDown()
    {

        if (gameObject.name == "ткацкий станок")
        {
            if (Input.GetMouseButtonDown(0))
            {


                float timeSinceLastClick = Time.time - lastClickTime;

                if (timeSinceLastClick <= DOubleClick)
                {

                    woolUi.SetActive(true);
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
