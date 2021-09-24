using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControllerSquizzer : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((cookJuice.slotArray[0] != 0) && (cookJuice.imageSlotArray[1] == 0))
        {
            particles.SetActive(true);
            
          
        }
        else
        {
            particles.SetActive(false);
          
           
        }
    }
}
