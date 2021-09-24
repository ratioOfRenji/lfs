using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brandNewPlanting : MonoBehaviour
{
    public Transform griadka1;
    public Transform griadka2;
    public Transform griadka3;
    public Transform griadka4;
    public Transform zemla1;
    public Transform zemla2;
    public Transform zemla3;
    public Transform zemla4;
    public Sprite noPlantObject;
    public Sprite sunFlower1;
    public Sprite sunFlower2;
    public Sprite potato1;
    public Sprite potato2;
    public Sprite carrot1;
    public Sprite carrot2;
    public string currentSeed;

    private void OnMouseDown()
    {
        if(gameObject.name == "griadka1")
        {
            Debug.Log("это работает");
        }
        // он маус давн использует нажатие мышки 
        if (GMScript1.currentTool == "scythe")
        {
            GetComponent<SpriteRenderer>().sprite = noPlantObject;
        }
        if ((GMScript1.currentTool == "sunflower") && (GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.sunFlowerSeeds > 0) && (gameObject.name == "грядка"))
        {
            GMScript1.boolSunflower1 = true;
            currentSeed = "sunflower";
            GMScript1.sunFlowerSeeds--;
        }
        if ((GMScript1.currentTool == "carrot") && (GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.carrotSeeds > 0))
        {
            GMScript1.boolCarrot1 = true;
            currentSeed = "sunflower";
            GMScript1.carrotSeeds--;

        }
        if ((GMScript1.currentTool == "potato") && (GetComponent<SpriteRenderer>().sprite == noPlantObject) && (GMScript1.potatoSeeds > 0))
        {
            GMScript1.boolPotato1 = true;

            currentSeed = "potato";
            GMScript1.potatoSeeds--;


        }
        if (GMScript1.currentTool == "vedro1")
        {
            GMScript1.boolWatered = true;

        }
        if (GetComponent<SpriteRenderer>().sprite == sunFlower2)
        {
            GMScript1.boolSunflower2 = false;
            GMScript1.sunFlowerSeeds += 2;
            GMScript1.boolWatered = false;
            zemla1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            GetComponent<SpriteRenderer>().sprite = noPlantObject;

        }
        if (GetComponent<SpriteRenderer>().sprite == carrot2)
        {
            GMScript1.boolCarrot2 = false;

            GMScript1.carrotSeeds += 2;
            GetComponent<SpriteRenderer>().sprite = noPlantObject;

        }
        if (GetComponent<SpriteRenderer>().sprite == potato2)
        {
            GMScript1.boolPotato2 = false;
            GMScript1.potatoSeeds += 2;
            GetComponent<SpriteRenderer>().sprite = noPlantObject;

        }

    }
}
