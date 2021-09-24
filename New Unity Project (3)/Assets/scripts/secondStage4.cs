using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondStage4 : MonoBehaviour
{
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public Transform griadka4;
    void Update()
    {

        if (GMScript1.fourBoolSunflower1)
        {
            griadka4.GetComponent<SpriteRenderer>().sprite = sunFlower1;

        }
        if (GMScript1.fourBoolCarrot1)
        {
            griadka4.GetComponent<SpriteRenderer>().sprite = carrot1;


        }
        if (GMScript1.fourBoolPotato1)
        {
            griadka4.GetComponent<SpriteRenderer>().sprite = potato1;


        }
        if (GMScript1.fourBoolSunflower2)
        {
            griadka4.GetComponent<SpriteRenderer>().sprite = sunFlower2;
            GMScript1.fourBoolWatered = false;

        }
        if (GMScript1.fourBoolCarrot2)
        {
            griadka4.GetComponent<SpriteRenderer>().sprite = carrot2;
            GMScript1.fourBoolWatered = false;
        }

        if (GMScript1.fourBoolPotato2)
        {
            griadka4.GetComponent<SpriteRenderer>().sprite = potato2;
            GMScript1.fourBoolWatered = false;

        }

    }
}
