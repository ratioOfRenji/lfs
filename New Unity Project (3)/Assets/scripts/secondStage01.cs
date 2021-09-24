using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondStage01 : MonoBehaviour
{
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public Transform griadka01;

    void Update()
    {

        if (GMScript1.boolSunflower1)
        {
            griadka01.GetComponent<SpriteRenderer>().sprite = sunFlower1;

        }
        if (GMScript1.boolCarrot1)
        {
            griadka01.GetComponent<SpriteRenderer>().sprite = carrot1;


        }
        if (GMScript1.boolPotato1)
        {
            griadka01.GetComponent<SpriteRenderer>().sprite = potato1;


        }
        if (GMScript1.boolSunflower2)
        {
            griadka01.GetComponent<SpriteRenderer>().sprite = sunFlower2;
            GMScript1.boolWatered = false;

        }
        if (GMScript1.boolCarrot2)
        {
            griadka01.GetComponent<SpriteRenderer>().sprite = carrot2;
            GMScript1.boolWatered = false;
        }

        if (GMScript1.boolPotato2)
        {
            griadka01.GetComponent<SpriteRenderer>().sprite = potato2;
            GMScript1.boolWatered = false;

        }

    }
}
