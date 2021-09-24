using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantControl2 : MonoBehaviour
{
    public Sprite Onion;
    public Sprite noPlantObject;
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public float twoGrowTime = 0;
    public Transform grazObj;
    public Sprite mokrayaGraz;
    public string watered = "none";
    public string currentSeed;
    public int coins = 0;
    public Transform griadka2;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (GMScript1.twoBoolWatered == false)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        if (GMScript1.twoBoolWatered)
        {
            grazObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);

        }
        //запускает таймер после посадки и уничтожает растерие если его не полили
        if (GMScript1.twoBoolSunflower1 | GMScript1.twoBoolCarrot1 | GMScript1.twoBoolPotato1)
        {
            twoGrowTime += Time.deltaTime;
        }
        if ((twoGrowTime > 5) && (GMScript1.twoBoolWatered == false))
        {
            currentSeed = "";
            twoGrowTime = 0;
            griadka2.GetComponent<SpriteRenderer>().sprite = noPlantObject;

        }
        // если время прошло, меняет росток на готовое растение
        if ((twoGrowTime > 5) && (GMScript1.twoBoolWatered))
        {
            if (griadka2.GetComponent<SpriteRenderer>().sprite == sunFlower1)
            {

                GMScript1.twoBoolSunflower1 = false;
                GMScript1.twoBoolSunflower2 = true;

            }

            if (griadka2.GetComponent<SpriteRenderer>().sprite == carrot1)
            {
                GMScript1.twoBoolCarrot1 = false;
                GMScript1.twoBoolCarrot2 = true;

            }

            if (griadka2.GetComponent<SpriteRenderer>().sprite == potato1)
            {
                GMScript1.twoBoolPotato1 = false;
                GMScript1.twoBoolPotato2 = true;
            }
            currentSeed = "";
            twoGrowTime = 0;




        }
        

    }
    private void OnMouseDown()
    {
        // он маус давн использует нажатие мышки 
        if (GMScript1.currentTool == "scythe")
        {
            griadka2.GetComponent<SpriteRenderer>().sprite = noPlantObject;
        }
        if ((GMScript1.currentTool == "sunflower") && (griadka2.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.sunFlowerSeeds > 0))
        {
            GMScript1.twoBoolSunflower1 = true;
            currentSeed = "sunflower";
            GMScript1.sunFlowerSeeds--;
        }
        if ((GMScript1.currentTool == "carrot") && (griadka2.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.carrotSeeds > 0))
        {
            GMScript1.twoBoolCarrot1 = true;
            currentSeed = "sunflower";
            GMScript1.carrotSeeds--;

        }
        if ((GMScript1.currentTool == "potato") && (griadka2.GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.potatoSeeds > 0))
        {
            GMScript1.twoBoolPotato1 = true;

            currentSeed = "potato";
            GMScript1.potatoSeeds--;


        }
        if (GMScript1.currentTool == "vedro1")
        {
            GMScript1.twoBoolWatered = true;

        }
        if (griadka2.GetComponent<SpriteRenderer>().sprite == sunFlower2)
        {
            GMScript1.twoBoolSunflower2 = false;
            GMScript1.sunFlowerSeeds += 2;
            GMScript1.twoBoolWatered = false;
            grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            griadka2.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka2.GetComponent<SpriteRenderer>().sprite == carrot2)
        {
            GMScript1.twoBoolCarrot2 = false;

            GMScript1.carrotSeeds += 2;
            griadka2.GetComponent<SpriteRenderer>().sprite = Onion;

        }
        if (griadka2.GetComponent<SpriteRenderer>().sprite == potato2)
        {
            GMScript1.twoBoolPotato2 = false;
            GMScript1.potatoSeeds += 2;
            griadka2.GetComponent<SpriteRenderer>().sprite = Onion;

        }

    }

}
