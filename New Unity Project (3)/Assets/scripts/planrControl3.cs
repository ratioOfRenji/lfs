using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planrControl3 : MonoBehaviour
{
    public Sprite Onion;
    public Sprite noPlantObject;
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public float threeGrowTime = 0;
    public Transform grazObj;
    public Sprite mokrayaGraz;
    public string watered = "none";
    public string currentSeed;
    public int coins = 0;
    public Transform griadka3;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (GMScript1.threeBoolWatered == false)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        if (GMScript1.threeBoolWatered)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);

        }
        //запускает таймер после посадки и уничтожает растерие если его не полили
        if (GMScript1.threeBoolSunflower1 | GMScript1.threeBoolCarrot1 | GMScript1.threeBoolPotato1)
        {
            threeGrowTime += Time.deltaTime;
        }
        if ((threeGrowTime > 5) && (GMScript1.threeBoolWatered == false))
        {
            currentSeed = "";
            threeGrowTime = 0;
            griadka3.GetComponent<SpriteRenderer>().sprite = noPlantObject;

        }
        // если время прошло, меняет росток на готовое растение
        if ((threeGrowTime > 5) && (GMScript1.threeBoolWatered))
        {
            if (griadka3.GetComponent<SpriteRenderer>().sprite == sunFlower1)
            {

                GMScript1.threeBoolSunflower1 = false;
                GMScript1.threeBoolSunflower2 = true;

            }

            if (griadka3.GetComponent<SpriteRenderer>().sprite == carrot1)
            {
                GMScript1.threeBoolCarrot1 = false;
                GMScript1.threeBoolCarrot2 = true;

            }

            if (griadka3.GetComponent<SpriteRenderer>().sprite == potato1)
            {
                GMScript1.threeBoolPotato1 = false;
                GMScript1.threeBoolPotato2 = true;
            }
            currentSeed = "";
            threeGrowTime = 0;




        }


    }
    private void OnMouseDown()
    {
        // он маус давн использует нажатие мышки 
        if (GMScript1.currentTool == "scythe")
        {
            griadka3.GetComponent<SpriteRenderer>().sprite = noPlantObject;
        }
        if ((GMScript1.currentTool == "sunflower") && (griadka3.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.sunFlowerSeeds > 0))
        {
            GMScript1.threeBoolSunflower1 = true;
            currentSeed = "sunflower";
            GMScript1.sunFlowerSeeds--;
        }
        if ((GMScript1.currentTool == "carrot") && (griadka3.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.carrotSeeds > 0))
        {
            GMScript1.threeBoolCarrot1 = true;
            currentSeed = "sunflower";
            GMScript1.carrotSeeds--;

        }
        if ((GMScript1.currentTool == "potato") && (griadka3.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.potatoSeeds > 0))
        {
            GMScript1.threeBoolPotato1 = true;

            currentSeed = "potato";
            GMScript1.potatoSeeds--;


        }
        if (GMScript1.currentTool == "vedro1")
        {
            GMScript1.threeBoolWatered = true;

        }
        if (griadka3.GetComponent<SpriteRenderer>().sprite == sunFlower2)
        {
            GMScript1.threeBoolSunflower2 = false;
            GMScript1.sunFlowerSeeds += 2;
            GMScript1.threeBoolWatered = false;
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            griadka3.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka3.GetComponent<SpriteRenderer>().sprite == carrot2)
        {
            GMScript1.threeBoolCarrot2 = false;

            GMScript1.carrotSeeds += 2;
            griadka3.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka3.GetComponent<SpriteRenderer>().sprite == potato2)
        {
            GMScript1.threeBoolPotato2 = false;
            GMScript1.potatoSeeds += 2;
            griadka3.GetComponent<SpriteRenderer>().sprite = Onion;

        }

    }
}
