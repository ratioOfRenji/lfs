using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookWineFactory : MonoBehaviour
{
    public GameObject popUp;

    public int requiredNumberFirstItem;
    public int requiredNumberSecondItem;
    public int requiredNumberThirdItem;
    

    public static int[] slotArray = new int[2] { 0, 0 };
    public static int[] imageSlotArray = new int[2] { 0, 0 };

    public GameObject first;
    public GameObject second;

    public Sprite firstIm;
    public Sprite secondIm;
    public Sprite thirdIm;

    public static int firstTimeToCook = 7000;
    public static int secondTimeToCook = 8000;
    public static int thirdTimeToCook = 9000;

    public static float oneTimer;
    bool startOneTimer;

    public void CookFirstItem()
    {
        Debug.Log("винограда: " + GMScript1.grape);
        if (GMScript1.grape >= requiredNumberFirstItem)
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим вино!");
                    GMScript1.grape -= requiredNumberFirstItem;
                    Debug.Log("винограда: " + GMScript1.grape);
                    startOneTimer = true;
                    slotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = firstIm;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим вино!");
                        GMScript1.grape -= requiredNumberFirstItem;
                        Debug.Log("винограда: " + GMScript1.grape);
                        slotArray[1] = 1;
                        second.GetComponent<SpriteRenderer>().sprite = firstIm;
                    }
                }
            }

        }



    }
    public void activatePopUp()
    {
        popUp.SetActive(true);
    }



    public void cookSecondItem()
    {
        Debug.Log("белого винограда: " + GMScript1.whiteGrape);
        if (GMScript1.cowMilk >=requiredNumberSecondItem)
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    Debug.Log("готовим белое вино!");
                    GMScript1.whiteGrape -= requiredNumberSecondItem;
                    Debug.Log("белого винограда: " + GMScript1.whiteGrape);
                    startOneTimer = true;
                    slotArray[0] = 2;
                    //first.GetComponent<SpriteRenderer>().sprite = butterIm;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим белое вино!");
                        GMScript1.whiteGrape -= requiredNumberSecondItem;
                        Debug.Log("белого винограда: " + GMScript1.whiteGrape);
                        startOneTimer = true;
                        slotArray[1] = 2;
                        // second.GetComponent<SpriteRenderer>().sprite = butterIm;
                    }
                }
            }
        }
    }
   



    public void CookThirdItem()
    {

        Debug.Log("розового винограда: " + GMScript1.pinkGrape);
        if (GMScript1.cherry >= requiredNumberThirdItem)
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим розовое вино!");
                    GMScript1.cherry -= requiredNumberThirdItem;
                    Debug.Log("розового винограда: " + GMScript1.pinkGrape);
                    startOneTimer = true;
                    slotArray[0] = 3;

                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим розовое вино!");
                        GMScript1.cherry -= requiredNumberThirdItem; ;
                        Debug.Log("розового винограда: " + GMScript1.pinkGrape);
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
            if (oneTimer >= firstTimeToCook)
            {
                if ((slotArray[0] == 1) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUp();
                    oneTimer = 0;
                    slotArray[0] = 0;
                    imageSlotArray[1] = 1;
                    second.GetComponent<SpriteRenderer>().sprite = firstIm;
                }

                if ((slotArray[0] == 1) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUp();
                    oneTimer = 0;
                    imageSlotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = firstIm;
                    slotArray[0] = slotArray[1];
                    slotArray[1] = 0;
                    if (slotArray[0] != 0)
                    {
                        startOneTimer = true;
                    }
                }

                if (oneTimer >= secondTimeToCook)
                {

                    if ((slotArray[0] == 2) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        slotArray[0] = 0;
                        imageSlotArray[1] = 2;
                        second.GetComponent<SpriteRenderer>().sprite = secondIm;
                    }

                    if ((slotArray[0] == 2) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        imageSlotArray[0] = 2;
                        first.GetComponent<SpriteRenderer>().sprite = secondIm;
                        slotArray[0] = slotArray[1];
                        slotArray[1] = 0;
                        if (slotArray[0] != 0)
                        {
                            startOneTimer = true;
                        }
                    }

                }

                if (oneTimer >= thirdTimeToCook)
                {

                    if ((slotArray[0] == 3) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        slotArray[0] = 0;
                        imageSlotArray[1] = 3;
                        second.GetComponent<SpriteRenderer>().sprite = thirdIm;
                    }

                    if ((slotArray[0] == 3) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUp();
                        oneTimer = 0;
                        imageSlotArray[0] = 3;
                        first.GetComponent<SpriteRenderer>().sprite = thirdIm;
                        slotArray[0] = slotArray[1];
                        slotArray[1] = 0;
                        if (slotArray[0] != 0)
                        {
                            startOneTimer = true;
                        }
                    }

                }


                //   if (slotArray[0] == 3)
                //   {
                //       activatePopUpYogurt();
                //       startOneTimer = false;
                //       oneTimer = 0;
                //       imageSlotArray[0] = 3;
                //       slotArray[0] = slotArray[1];
                //       slotArray[1] = 0;
                //       if (slotArray[0] != 0)
                //       {
                //           startOneTimer = true;
                //       }
                //    }


            }
        }
        if (imageSlotArray[0] == 0)
        {
            first.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (imageSlotArray[1] == 0)
        {
            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if ((imageSlotArray[0] != 0) || (imageSlotArray[1] != 0))
        {
            popUp.SetActive(true);
        }
    }
}
