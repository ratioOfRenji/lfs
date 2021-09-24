using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControllerGrill : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((cookGrill.slotArray[0] != 0) && (cookGrill.imageSlotArray[1] == 0))
        {
            particles.SetActive(true);
            
        }
        else
        {
            particles.SetActive(false);
            
        }
    }
}
