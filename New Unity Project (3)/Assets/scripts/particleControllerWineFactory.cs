using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControllerWineFactory : MonoBehaviour
{
    public GameObject[] particles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((cookWineFactory.slotArray[0] != 0) && (cookWineFactory.imageSlotArray[1] == 0))
        {
            particles[0].SetActive(true);
            particles[1].SetActive(true);
           
        }
        else
        {
            particles[0].SetActive(false);
            particles[1].SetActive(false);
            
        }
    }
}
