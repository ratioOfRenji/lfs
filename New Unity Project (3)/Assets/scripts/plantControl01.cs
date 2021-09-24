using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantControl01 : MonoBehaviour
{
    public Sprite Onion;
    public Sprite noPlantObject;
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public float growTime = 0;
    public Transform grazObj;
    public Sprite mokrayaGraz;
    public string watered = "none";
    public string currentSeed;
    public int coins = 0;
    public Transform griadka01;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (GMScript1.boolWatered == false)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        if (GMScript1.boolWatered)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);

        }
        //запускает таймер после посадки и уничтожает растерие если его не полили
        if (GMScript1.boolSunflower1 | GMScript1.boolCarrot1 | GMScript1.boolPotato1)
        {
            growTime += Time.deltaTime;
        }
        if ((growTime > 5) && (GMScript1.boolWatered == false))
        {
            currentSeed = "";
            growTime = 0;
            griadka01.GetComponent<SpriteRenderer>().sprite = noPlantObject;

        }
        // если время прошло, меняет росток на готовое растение
        if ((growTime > 5) && (GMScript1.boolWatered))
        {
            if (griadka01.GetComponent<SpriteRenderer>().sprite == sunFlower1)
            {

                GMScript1.boolSunflower1 = false;
                GMScript1.boolSunflower2 = true;

            }

            if (griadka01.GetComponent<SpriteRenderer>().sprite == carrot1)
            {
                GMScript1.boolCarrot1 = false;
                GMScript1.boolCarrot2 = true;

            }

            if (griadka01.GetComponent<SpriteRenderer>().sprite == potato1)
            {
                GMScript1.boolPotato1 = false;
                GMScript1.boolPotato2 = true;
            }
            currentSeed = "";
            growTime = 0;




        }


    }
    private void OnMouseDown()
    {
        // он маус давн использует нажатие мышки 
        if (GMScript1.currentTool == "scythe")
        {
            griadka01.GetComponent<SpriteRenderer>().sprite = noPlantObject;
        }
        if ((GMScript1.currentTool == "sunflower") && (griadka01.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.sunFlowerSeeds > 0))
        {
            GMScript1.boolSunflower1 = true;
            currentSeed = "sunflower";
            GMScript1.sunFlowerSeeds--;
        }
        if ((GMScript1.currentTool == "carrot") && (griadka01.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.carrotSeeds > 0))
        {
            GMScript1.boolCarrot1 = true;
            currentSeed = "sunflower";
            GMScript1.carrotSeeds--;

        }
        if ((GMScript1.currentTool == "potato") && (griadka01.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.potatoSeeds > 0))
        {
            GMScript1.boolPotato1 = true;

            currentSeed = "potato";
            GMScript1.potatoSeeds--;


        }
        if (GMScript1.currentTool == "vedro1")
        {
            GMScript1.boolWatered = true;

        }
        if (griadka01.GetComponent<SpriteRenderer>().sprite == sunFlower2)
        {
            GMScript1.boolSunflower2 = false;
            GMScript1.sunFlowerSeeds += 2;
            GMScript1.boolWatered = false;
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            griadka01.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka01.GetComponent<SpriteRenderer>().sprite == carrot2)
        {
            GMScript1.boolCarrot2 = false;

            GMScript1.carrotSeeds += 2;
            griadka01.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka01.GetComponent<SpriteRenderer>().sprite == potato2)
        {
            GMScript1.boolPotato2 = false;
            GMScript1.potatoSeeds += 2;
            griadka01.GetComponent<SpriteRenderer>().sprite = Onion;

        }

    }
}
