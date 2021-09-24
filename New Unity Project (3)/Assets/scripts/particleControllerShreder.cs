using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControllerShreder : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((cookShreder.slotArray[0] != 0) && (cookShreder.imageSlotArray[1] == 0))
        {
            particles.SetActive(true);
           
        }
        else
        {
            particles.SetActive(false);
           
        }
    }
}
