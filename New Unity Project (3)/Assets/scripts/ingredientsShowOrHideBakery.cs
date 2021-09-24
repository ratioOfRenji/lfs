using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredientsShowOrHideBakery : MonoBehaviour
{
    public GameObject wheat;
    public GameObject milk;

    // Update is called once per frame
    void Update()
    {
        if(GMScript1.sunFlowerSeeds > 0)
        {
            wheat.SetActive(true);
        }
        if (GMScript1.cowMilk > 0)
        {
            milk.SetActive(true);
        }
        if (GMScript1.sunFlowerSeeds <= 0)
        {
            wheat.SetActive(false);
        }
        if (GMScript1.cowMilk <= 0)
        {
            milk.SetActive(false);
        }
    }
}
