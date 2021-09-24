using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantControl4 : MonoBehaviour
{
    public Sprite Onion;
    public Sprite noPlantObject;
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public float fourGrowTime = 0;
    public Transform grazObj;
    public Sprite mokrayaGraz;
    public string watered = "none";
    public string currentSeed;
    public int coins = 0;
    public Transform griadka4;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (GMScript1.fourBoolWatered == false)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        if (GMScript1.fourBoolWatered)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);

        }
        //запускает таймер после посадки и уничтожает растерие если его не полили
        if (GMScript1.fourBoolSunflower1 | GMScript1.fourBoolCarrot1 | GMScript1.fourBoolPotato1)
        {
            fourGrowTime += Time.deltaTime;
        }
        if ((fourGrowTime > 5) && (GMScript1.fourBoolWatered == false))
        {
            currentSeed = "";
            fourGrowTime = 0;
            griadka4.GetComponent<SpriteRenderer>().sprite = noPlantObject;

        }
        // если время прошло, меняет росток на готовое растение
        if ((fourGrowTime > 5) && (GMScript1.fourBoolWatered))
        {
            if (griadka4.GetComponent<SpriteRenderer>().sprite == sunFlower1)
            {

                GMScript1.fourBoolSunflower1 = false;
                GMScript1.fourBoolSunflower2 = true;

            }

            if (griadka4.GetComponent<SpriteRenderer>().sprite == carrot1)
            {
                GMScript1.fourBoolCarrot1 = false;
                GMScript1.fourBoolCarrot2 = true;

            }

            if (griadka4.GetComponent<SpriteRenderer>().sprite == potato1)
            {
                GMScript1.fourBoolPotato1 = false;
                GMScript1.fourBoolPotato2 = true;
            }
            currentSeed = "";
            fourGrowTime = 0;




        }


    }
    private void OnMouseDown()
    {
        // он маус давн использует нажатие мышки 
        if (GMScript1.currentTool == "scythe")
        {
            griadka4.GetComponent<SpriteRenderer>().sprite = noPlantObject;
        }
        if ((GMScript1.currentTool == "sunflower") && (griadka4.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.sunFlowerSeeds > 0))
        {
            GMScript1.fourBoolSunflower1 = true;
            currentSeed = "sunflower";
            GMScript1.sunFlowerSeeds--;
        }
        if ((GMScript1.currentTool == "carrot") && (griadka4.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.carrotSeeds > 0))
        {
            GMScript1.fourBoolCarrot1 = true;
            currentSeed = "sunflower";
            GMScript1.carrotSeeds--;

        }
        if ((GMScript1.currentTool == "potato") && (griadka4.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.potatoSeeds > 0))
        {
            GMScript1.fourBoolPotato1 = true;

            currentSeed = "potato";
            GMScript1.potatoSeeds--;


        }
        if (GMScript1.currentTool == "vedro1")
        {
            GMScript1.fourBoolWatered = true;

        }
        if (griadka4.GetComponent<SpriteRenderer>().sprite == sunFlower2)
        {
            GMScript1.fourBoolSunflower2 = false;
            GMScript1.sunFlowerSeeds += 2;
            GMScript1.fourBoolWatered = false;
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            griadka4.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka4.GetComponent<SpriteRenderer>().sprite == carrot2)
        {
            GMScript1.fourBoolCarrot2 = false;

            GMScript1.carrotSeeds += 2;
            griadka4.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka4.GetComponent<SpriteRenderer>().sprite == potato2)
        {
            GMScript1.fourBoolPotato2 = false;
            GMScript1.potatoSeeds += 2;
            griadka4.GetComponent<SpriteRenderer>().sprite = Onion;

        }

    }
}
