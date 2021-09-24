using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondStage2 : MonoBehaviour
{

    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public Transform griadka2;

    void Update()
    {

        if (GMScript1.twoBoolSunflower1)
        {
            griadka2.GetComponent<SpriteRenderer>().sprite = sunFlower1;

        }
        if (GMScript1.twoBoolCarrot1)
        {
            griadka2.GetComponent<SpriteRenderer>().sprite = carrot1;


        }
        if (GMScript1.twoBoolPotato1)
        {
            griadka2.GetComponent<SpriteRenderer>().sprite = potato1;


        }
        if (GMScript1.twoBoolSunflower2)
        {
            griadka2.GetComponent<SpriteRenderer>().sprite = sunFlower2;
            GMScript1.twoBoolWatered = false;

        }
        if (GMScript1.twoBoolCarrot2)
        {
            griadka2.GetComponent<SpriteRenderer>().sprite = carrot2;
            GMScript1.twoBoolWatered = false;
        }

        if (GMScript1.twoBoolPotato2)
        {
            griadka2.GetComponent<SpriteRenderer>().sprite = potato2;
            GMScript1.twoBoolWatered = false;

        }

    }
}
