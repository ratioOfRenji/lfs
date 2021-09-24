using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookWoolFactory : MonoBehaviour
{
    public int requiredNumberSugarPlant;
    public int requiredNumberCoffeBeans;


    public static int[] slotArray = new int[2] { 0, 0 };
    public static int[] imageSlotArray = new int[2] { 0, 0 };

    public GameObject first;
    public GameObject second;

    public Sprite sugar;
    public Sprite coffee;

    public static int sugarTimeToCook = 150;
    public static int coffeTimeToCook = 200;


    public GameObject popUp;
    public static float oneTimer;
    bool startOneTimer;

    public void CookWheatBread()
    {
        //Debug.Log("тростника: " + GMScript1.sugarPlantSeeds);
        if (GMScript1.wool >= requiredNumberSugarPlant) 
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    //  Debug.Log("готовим сахар!");
                    GMScript1.wool--;
                   
                    // Debug.Log("тростника: " + GMScript1.sugarPlantSeeds);
                    startOneTimer = true;
                    slotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = sugar;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        GMScript1.wool--;
                        slotArray[1] = 1;
                        second.GetComponent<SpriteRenderer>().sprite = sugar;
                    }
                }
            }

        }



    }
    public void activatePopUp()
    {
        popUp.SetActive(true);
    }



    //public void CookWhiteBread()
    //{
    //    // Debug.Log("семян кофе: " + GMScript1.coffeeSeeds);
    //    if ((GMScript1.sunFlowerSeeds >= requiredNumberCoffeBeans) && (GMScript1.yaytsa >= requiredNumberCoffeBeans) && (GMScript1.cowMilk >= requiredNumberCoffeBeans))
    //    {
    //        if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
    //        {
    //            if ((slotArray[0] == 0) && (imageSlotArray[1] == 0))
    //            {
    //                // Debug.Log("готовим кофе!");
    //                GMScript1.sunFlowerSeeds -= requiredNumberCoffeBeans;
    //                GMScript1.yaytsa -= requiredNumberCoffeBeans;
    //                GMScript1.cowMilk -= requiredNumberCoffeBeans;
    //                // Debug.Log("семян кофе: " + GMScript1.coffeeSeeds);
    //                startOneTimer = true;
    //                slotArray[0] = 2;
    //                //first.GetComponent<SpriteRenderer>().sprite = butterIm;
    //            }
    //            else
    //            {
    //                if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
    //                {
    //                    // Debug.Log("готовим кофе!");
    //                    GMScript1.sunFlowerSeeds -= requiredNumberCoffeBeans;
    //                    GMScript1.yaytsa -= requiredNumberCoffeBeans;
    //                    GMScript1.cowMilk -= requiredNumberCoffeBeans;
    //                    //  Debug.Log("семян кофе: " + GMScript1.coffeeSeeds);
    //                    startOneTimer = true;
    //                    slotArray[1] = 2;
    //                    // second.GetComponent<SpriteRenderer>().sprite = butterIm;
    //                }
    //            }
    //        }
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if ((slotArray[0] != 0) || (slotArray[1] != 0))
        {
            oneTimer += Time.deltaTime;
            if (oneTimer >= sugarTimeToCook)
            {
                if ((slotArray[0] == 1) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUp();
                    oneTimer = 0;
                    slotArray[0] = 0;
                    imageSlotArray[1] = 1;
                    second.GetComponent<SpriteRenderer>().sprite = sugar;
                }

                if ((slotArray[0] == 1) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUp();
                    oneTimer = 0;
                    imageSlotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = sugar;
                    slotArray[0] = slotArray[1];
                    slotArray[1] = 0;
                    if (slotArray[0] != 0)
                    {
                        startOneTimer = true;
                    }
                }

                //if (oneTimer >= coffeTimeToCook)
                //{

                //    if ((slotArray[0] == 2) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                //    {
                //        startOneTimer = false;
                //        activatePopUp();
                //        oneTimer = 0;
                //        slotArray[0] = 0;
                //        imageSlotArray[1] = 2;
                //        second.GetComponent<SpriteRenderer>().sprite = coffee;
                //    }

                //    if ((slotArray[0] == 2) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                //    {
                //        startOneTimer = false;
                //        activatePopUp();
                //        oneTimer = 0;
                //        imageSlotArray[0] = 2;
                //        first.GetComponent<SpriteRenderer>().sprite = coffee;
                //        slotArray[0] = slotArray[1];
                //        slotArray[1] = 0;
                //        if (slotArray[0] != 0)
                //        {
                //            startOneTimer = true;
                //        }
                //    }

                //}
            }
        }
        if ((imageSlotArray[0] != 0) || (imageSlotArray[1] != 0))
        {
            popUp.SetActive(true);
        }
        if (imageSlotArray[0] == 0)
        {
            first.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (imageSlotArray[1] == 0)
        {
            second.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
