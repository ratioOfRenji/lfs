using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookJuice : MonoBehaviour
{
    public GameObject popUp;


    public int requiredNumberOfApplesForFirst;
    public int reqiredNumberOfSugarForFirst;

    public int reqiredNumerOfGrapeForSecond;
    public int reqiredNumberOfSugarForSecond;
    

    public int reqiredNumerOfCherryForThirdd;
    public int reqiredNumberOfSugarForThird;
   


    public static int[] slotArray = new int[2] { 0, 0 };
    public static int[] imageSlotArray = new int[2] { 0, 0 };

    public GameObject first;
    public GameObject second;

    public Sprite firstItemImage;
    public Sprite secondItemImage;
    public Sprite thirdItemImage;

    public static int firstItemTimeToCook = 7;
    public static int secondItemTimeToCook = 8;
    public static int thirdItemTimeToCook = 9;

    public static float oneTimer;
    bool startOneTimer;

    public void CookFirstItem()
    {
        Debug.Log("яблок: " + GMScript1.apple + "сахара: " + GMScript1.sugar);
        if ((GMScript1.apple >= requiredNumberOfApplesForFirst) && (GMScript1.sugar >= reqiredNumberOfSugarForFirst))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим яблочный сок!");
                    GMScript1.apple -= requiredNumberOfApplesForFirst;
                    GMScript1.sugar -= reqiredNumberOfSugarForFirst;
                    Debug.Log("яблок: " + GMScript1.apple + "сахара: " + GMScript1.sugar);
                    startOneTimer = true;
                    slotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = firstItemImage;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим яблочный сок!");
                        GMScript1.apple -= requiredNumberOfApplesForFirst;
                        GMScript1.sugar -= reqiredNumberOfSugarForFirst;
                        Debug.Log("яблок: " + GMScript1.apple + "сахара: " + GMScript1.sugar);
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
        Debug.Log("винограда: " + GMScript1.grape + "сахара: " + GMScript1.sugar);
        if ((GMScript1.cowMilk >= reqiredNumerOfGrapeForSecond) && (GMScript1.sugar >= reqiredNumberOfSugarForSecond))
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    Debug.Log("готовим виноградный сок!");
                    GMScript1.grape -= reqiredNumerOfGrapeForSecond;
                    GMScript1.sugar -= reqiredNumberOfSugarForSecond;
                    Debug.Log("винограда: " + GMScript1.grape + "сахара: " + GMScript1.sugar);
                    startOneTimer = true;
                    slotArray[0] = 2;

                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим виноградный сок!");
                        GMScript1.grape -= reqiredNumerOfGrapeForSecond;
                        GMScript1.sugar -= reqiredNumberOfSugarForSecond;
                        Debug.Log("винограда: " + GMScript1.grape + "сахара: " + GMScript1.sugar);
                        startOneTimer = true;
                        slotArray[1] = 2;
                    }
                }
            }
        }
    }




    public void CookThirdItem()
    {

        Debug.Log("винограда: " + GMScript1.cherry + "сахара: " + GMScript1.sugar);
        if ((GMScript1.cherry >= reqiredNumerOfCherryForThirdd) && (GMScript1.sugar >= reqiredNumberOfSugarForThird) )
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим вишневый сок!");
                    GMScript1.cherry -= reqiredNumerOfCherryForThirdd;
                    GMScript1.sugar -= reqiredNumberOfSugarForThird;
                    Debug.Log("винограда: " + GMScript1.cherry + "сахара: " + GMScript1.sugar);
                    startOneTimer = true;
                    slotArray[0] = 3;

                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим вишневый сок!");
                        GMScript1.cherry -= reqiredNumerOfCherryForThirdd;
                        GMScript1.sugar -= reqiredNumberOfSugarForThird;
                        Debug.Log("винограда: " + GMScript1.cherry + "сахара: " + GMScript1.sugar);
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
