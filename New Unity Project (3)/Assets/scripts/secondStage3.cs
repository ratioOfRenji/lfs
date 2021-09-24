using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondStage3 : MonoBehaviour
{
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public Transform griadka3;
    void Update()
    {

        if (GMScript1.threeBoolSunflower1)
        {
            griadka3.GetComponent<SpriteRenderer>().sprite = sunFlower1;

        }
        if (GMScript1.threeBoolCarrot1)
        {
            griadka3.GetComponent<SpriteRenderer>().sprite = carrot1;


        }
        if (GMScript1.threeBoolPotato1)
        {
            griadka3.GetComponent<SpriteRenderer>().sprite = potato1;


        }
        if (GMScript1.threeBoolSunflower2)
        {
            griadka3.GetComponent<SpriteRenderer>().sprite = sunFlower2;
            GMScript1.threeBoolWatered = false;

        }
        if (GMScript1.threeBoolCarrot2)
        {
            griadka3.GetComponent<SpriteRenderer>().sprite = carrot2;
            GMScript1.threeBoolWatered = false;
        }

        if (GMScript1.threeBoolPotato2)
        {
            griadka3.GetComponent<SpriteRenderer>().sprite = potato2;
            GMScript1.threeBoolWatered = false;

        }

    }
}
