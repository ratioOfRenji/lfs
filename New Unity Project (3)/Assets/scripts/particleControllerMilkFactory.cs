using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControllerMilkFactory : MonoBehaviour
{
    public GameObject[] particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((cookMilkFactory.slotArray[0] != 0) &&(cookMilkFactory.imageSlotArray[1] == 0))
        {
            particles[0].SetActive(true);
            particles[1].SetActive(true);
            particles[2].SetActive(true);
        }
        else
        {
            particles[0].SetActive(false);
            particles[1].SetActive(false);
            particles[2].SetActive(false);
        }
    }
}
