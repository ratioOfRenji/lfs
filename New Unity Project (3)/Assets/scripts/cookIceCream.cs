using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookIceCream : MonoBehaviour
{
    public GameObject popUp;


    public int requiredNumberOfMilkForFirst;
    public int reqiredNumberOfSugarForFirst;

    public int reqiredNumerOfMilkForSecond;
    public int reqiredNumberOfSugarForSecond;
    public int reqiredNumbeOfChocholateForSecond;

    public int reqiredNumerOfMilkForThirdd;
    public int reqiredNumberOfSugarForthird;
    public int reqiredNumbeOfRaspberriesForThird;


    public static int[] slotArray = new int[2] { 0, 0 };
    public static int[] imageSlotArray = new int[2] { 0, 0 };

    public GameObject first;
    public GameObject second;

    public Sprite firstItemImage;
    public Sprite secondItemImage;
    public Sprite thirdItemImage;

    public static int firstItemTimeToCook = 7;
    public static int secondItemTimeToCook = 8;
    public static int thirdItemTimeToCook = 900;

    public static float oneTimer;
    bool startOneTimer;

    public void CookFirstItem()
    {
        Debug.Log("козькго молока: " + GMScript1.goatMilk + "сахара: " + GMScript1.sugar);
        if ((GMScript1.goatMilk >= requiredNumberOfMilkForFirst) &&(GMScript1.sugar >= reqiredNumberOfSugarForFirst))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим молочное мороженное!");
                    GMScript1.goatMilk -= requiredNumberOfMilkForFirst;
                    GMScript1.sugar -= reqiredNumberOfSugarForFirst;
                    Debug.Log("козькго молока: " + GMScript1.goatMilk + "сахара: " + GMScript1.sugar);
                    startOneTimer = true;
                    slotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = firstItemImage;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим молочное мороженное!");
                        GMScript1.goatMilk -= requiredNumberOfMilkForFirst;
                        GMScript1.sugar -= reqiredNumberOfSugarForFirst;
                        Debug.Log("козькго молока: " + GMScript1.goatMilk + "сахара: " + GMScript1.sugar);
                        slotArray[1] = 1;
                        second.GetComponent<SpriteRenderer>().sprite = firstItemImage;
                    }
                }
            }

        }



    }
    public void activatePopUp()
    {
        popUp.SetActive(true);
    }



    public void CookSecondItem()
    {
        Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "шоколада" + GMScript1.chocholate);
        if ((GMScript1.cowMilk >= reqiredNumerOfMilkForSecond) && (GMScript1.sugar >= reqiredNumberOfSugarForSecond) && (GMScript1.chocholate >= reqiredNumbeOfChocholateForSecond))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    Debug.Log("готовим шоколадное мороженное!");
                    GMScript1.cowMilk -= reqiredNumerOfMilkForSecond;
                    GMScript1.sugar -= reqiredNumberOfSugarForSecond;
                    GMScript1.chocholate -= reqiredNumbeOfChocholateForSecond;
                    Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "шоколада" + GMScript1.chocholate);
                    startOneTimer = true;
                    slotArray[0] = 2;
                    
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим шоколадное мороженное!");
                        GMScript1.cowMilk -= reqiredNumerOfMilkForSecond;
                        GMScript1.sugar -= reqiredNumberOfSugarForSecond;
                        GMScript1.chocholate -= reqiredNumbeOfChocholateForSecond;
                        Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "шоколада" + GMScript1.chocholate);
                        startOneTimer = true;
                        slotArray[1] = 2;
                    }
                    
                }
            }
        }
    }
    



    public void CookThirdItem()
    {

        Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "малины" + GMScript1.raspberries);
        if ((GMScript1.cowMilk >= reqiredNumerOfMilkForThirdd) && (GMScript1.sugar >= reqiredNumberOfSugarForSecond) && (GMScript1.raspberries >= reqiredNumbeOfRaspberriesForThird))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим малиновое мороженное!");
                    GMScript1.cowMilk -= reqiredNumerOfMilkForThirdd;
                    GMScript1.sugar -= reqiredNumberOfSugarForthird;
                    GMScript1.raspberries -= reqiredNumbeOfRaspberriesForThird;
                    Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "малины" + GMScript1.raspberries);
                    startOneTimer = true;
                    slotArray[0] = 3;

                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим малиновое мороженное!");
                        GMScript1.cowMilk -= reqiredNumerOfMilkForThirdd;
                        GMScript1.sugar -= reqiredNumberOfSugarForthird;
                        GMScript1.raspberries -= reqiredNumbeOfRaspberriesForThird;
                        Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "малины" + GMScript1.raspberries);
                        startOneTimer = true;
                        slotArray[1] = 3;
                    }

                }
            }
        }
    }
   

    private void Update()
    {



        if ((slotArray[0] != 0) || (slotArray[1] != 0))
        {
            oneTimer += Time.deltaTime;
            if (oneTimer >= firstItemTimeToCook)
            {
                if ((slotArray[0] == 1) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUp();
                    oneTimer = 0;
                    slotArray[0] = 0;
                    imageSlotArray[1] = 1;
                    second.GetComponent<SpriteRenderer>().sprite = firstItemImage;
                }

                if ((slotArray[0] == 1) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUp();
                    oneTimer = 0;
                    imageSlotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = firstItemImage;
                    slotArray[0] = slotArray[1];
                    slotArray[1] = 0;
                    if (slotArray[0] != 0)
                    {
                        startOneTimer = true;
                    }
                }

                if (oneTimer >=secondItemTimeToCook)
                {

                    if ((slotArray[0] == 2) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        slotArray[0] = 0;
                        imageSlotArray[1] = 2;
                        second.GetComponent<SpriteRenderer>().sprite = secondItemImage;
                    }

                    if ((slotArray[0] == 2) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        imageSlotArray[0] = 2;
                        first.GetComponent<SpriteRenderer>().sprite = secondItemImage;
                        slotArray[0] = slotArray[1];
                        slotArray[1] = 0;
                        if (slotArray[0] != 0)
                        {
                            startOneTimer = true;
                        }
                    }

                }

                if (oneTimer >= thirdItemTimeToCook)
                {

                    if ((slotArray[0] == 3) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        slotArray[0] = 0;
                        imageSlotArray[1] = 3;
                        second.GetComponent<SpriteRenderer>().sprite = thirdItemImage;
                    }

                    if ((slotArray[0] == 3) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        imageSlotArray[0] = 3;
                        first.GetComponent<SpriteRenderer>().sprite = thirdItemImage;
                        slotArray[0] = slotArray[1];
                        slotArray[1] = 0;
                        if (slotArray[0] != 0)
                        {
                            startOneTimer = true;
                        }
                    }

                }
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
