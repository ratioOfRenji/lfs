using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookSpagettiMachine : MonoBehaviour
{
    public GameObject popUp;


    public int requiredNumberOfPotatoForFirst;
    public int reqiredNumberOfWheatForFirst;

    public int reqiredNumerOfWheatForSecond;
    public int reqiredNumberOfEggsForSecond;
    public int reqiredNumbeOfMilkForSecond;

    public int reqiredNumerOfWheatForThirdd;
    public int reqiredNumberOfCarrotForthird;
    public int reqiredNumbeOfPotatosForThird;
    public int reqiredNumbeOfEggsForThird;
    public int reqiredNumbeOfMilkForThird;


    public static int[] slotArray = new int[2] { 0, 0 };
    public static int[] imageSlotArray = new int[2] { 0, 0 };

    public GameObject first;
    public GameObject second;

    public Sprite firstItemImage;
    public Sprite secondItemImage;
    public Sprite thirdItemImage;

    public static int firstItemTimeToCook = 70;
    public static int secondItemTimeToCook = 80;
    public static int thirdItemTimeToCook = 90;

    public static float oneTimer;
    bool startOneTimer;

    public void CookFirstItem()
    {
        Debug.Log("картошки: " + GMScript1.potatoSeeds + "пшеницы: " + GMScript1.sunFlowerSeeds);
        if ((GMScript1.goatMilk >= requiredNumberOfPotatoForFirst) && (GMScript1.sunFlowerSeeds >= reqiredNumberOfWheatForFirst))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим темные макароны!");
                    GMScript1.potatoSeeds -= requiredNumberOfPotatoForFirst;
                    GMScript1.sunFlowerSeeds -= reqiredNumberOfWheatForFirst;
                    Debug.Log("картошки: " + GMScript1.potatoSeeds + "пшеницы: " + GMScript1.sunFlowerSeeds);
                    startOneTimer = true;
                    slotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = firstItemImage;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим молочное мороженное!");
                        GMScript1.potatoSeeds -= requiredNumberOfPotatoForFirst;
                        GMScript1.sunFlowerSeeds -= reqiredNumberOfWheatForFirst;
                        Debug.Log("картошки: " + GMScript1.potatoSeeds + "пшеницы: " + GMScript1.sunFlowerSeeds);
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
       
       if ((GMScript1.sunFlowerSeeds >= reqiredNumerOfWheatForSecond) && (GMScript1.yaytsa >= reqiredNumberOfEggsForSecond) && (GMScript1.cowMilk >= reqiredNumbeOfMilkForSecond))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    Debug.Log("готовим макароны!");
                    GMScript1.sunFlowerSeeds -= reqiredNumerOfWheatForSecond;
                   GMScript1.yaytsa -= reqiredNumberOfEggsForSecond;
                    GMScript1.cowMilk -= reqiredNumbeOfMilkForSecond;
                 //  Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "шоколада" + GMScript1.chocholate);
                    startOneTimer = true;
                   slotArray[0] = 2;

                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим макароны!");
                        GMScript1.sunFlowerSeeds -= reqiredNumerOfWheatForSecond;
                        GMScript1.yaytsa -= reqiredNumberOfEggsForSecond;
                        GMScript1.cowMilk -= reqiredNumbeOfMilkForSecond;
                        //Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "шоколада" + GMScript1.chocholate);
                        startOneTimer = true;
                        slotArray[1] = 2;
                    }

                }
            }
       }
   }




    public void CookThirdItem()
    {

       // Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "малины" + GMScript1.raspberries);
        if ((GMScript1.sunFlowerSeeds >=reqiredNumerOfWheatForThirdd) && (GMScript1.carrotSeeds >= reqiredNumberOfCarrotForthird) && (GMScript1.yaytsa >= reqiredNumbeOfEggsForThird) && (GMScript1.cowMilk >= reqiredNumbeOfMilkForSecond) && (GMScript1.potatoSeeds >= requiredNumberOfPotatoForFirst))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим цветные макароны!");
                    GMScript1.cowMilk -=reqiredNumbeOfMilkForSecond;
                    GMScript1.sunFlowerSeeds -= reqiredNumerOfWheatForThirdd;
                    GMScript1.carrotSeeds -= reqiredNumberOfCarrotForthird;
                    GMScript1.potatoSeeds -= reqiredNumbeOfPotatosForThird;
                    GMScript1.yaytsa -= reqiredNumbeOfEggsForThird;
                    //Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "малины" + GMScript1.raspberries);
                    startOneTimer = true;
                    slotArray[0] = 3;

                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим цветные макароны!");
                        GMScript1.cowMilk -= reqiredNumbeOfMilkForSecond;
                        GMScript1.sunFlowerSeeds -= reqiredNumerOfWheatForThirdd;
                        GMScript1.carrotSeeds -= reqiredNumberOfCarrotForthird;
                        GMScript1.potatoSeeds -= reqiredNumbeOfPotatosForThird;
                        GMScript1.yaytsa -= reqiredNumbeOfEggsForThird;
                        // Debug.Log("коровьего молока: " + GMScript1.cowMilk + "сахара: " + GMScript1.sugar + "малины" + GMScript1.raspberries);
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

                if (oneTimer >= secondItemTimeToCook)
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
