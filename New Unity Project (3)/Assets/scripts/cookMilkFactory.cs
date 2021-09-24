using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookMilkFactory : MonoBehaviour, IUnit
{
    [SerializeField]
    private GameObject milkFactory;
     public GameObject popUp;
    

    public int requiredNumberButter;
    public int requiredNumberYogurt;


    public int requiredNumberCheese;
    public static int[] slotArray  = new int[2] { 0, 0 };
    public static int[] imageSlotArray = new int[2] { 0, 0 };
    

    public  GameObject first;
    public  GameObject second;

    public  Sprite cheeseIm;
    public Sprite butterIm;
    public  Sprite yogurtIm;

    public static int cheeseTimeToCook = 7;
    public static int butterTimeToCook =8;
    public static float yogurtTimeToCook = 90;

    public static float oneTimer;
    public static bool startOneTimer;

    public void CookCheese()
    {
        Debug.Log("козькго молока: " + GMScript1.goatMilk);
        if (GMScript1.goatMilk >= requiredNumberCheese)
        {
            if((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим сыр!");
                    GMScript1.goatMilk -= requiredNumberCheese;
                    Debug.Log("козькго молока: " + GMScript1.goatMilk);
                    startOneTimer= true;
                    slotArray[0] = 1;
                   // first.GetComponent<SpriteRenderer>().sprite = cheeseIm;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {

                    
                        Debug.Log("готовим сыр!");
                    GMScript1.goatMilk -= requiredNumberCheese;
                    Debug.Log("козькго молока: " + GMScript1.goatMilk);
                    slotArray[1] = 1;
                   // second.GetComponent<SpriteRenderer>().sprite = cheeseIm;
                    }
                }
            }
           
        }

       

    }
    public void activatePopUpCheese()
    {
        popUp.SetActive(true);
    }



    public void CookButter()
    {
        Debug.Log("коровьего молока: " + GMScript1.cowMilk);
        if (GMScript1.cowMilk >= requiredNumberButter)
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] == 0))
            {
                if ((slotArray[0] == 0) &&  (imageSlotArray[1] == 0))
                {
                    Debug.Log("готовим масло!");
                    GMScript1.cowMilk -= requiredNumberButter;
                    Debug.Log("коровьего молока: " + GMScript1.cowMilk);
                    startOneTimer = true;
                    slotArray[0] = 2;
                    //first.GetComponent<SpriteRenderer>().sprite = butterIm;
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим масло!");
                        GMScript1.cowMilk -= requiredNumberButter;
                        Debug.Log("коровьего молока: " + GMScript1.cowMilk);
                        startOneTimer = true;
                        slotArray[1] = 2;
                        // second.GetComponent<SpriteRenderer>().sprite = butterIm;
                    }
                }
            }
        }
    }
    public void activatePopUpButter()
    {
        popUp.SetActive(true);
    }



    public void CookYogurt()
    {

        Debug.Log("коровьего молока: " + GMScript1.cowMilk);
        if (GMScript1.cowMilk >= requiredNumberYogurt)
        {
            if ((slotArray[1] == 0) && (imageSlotArray[1] ==0))
            {
                if ((slotArray[0] == 0) && (imageSlotArray[0] == 0))
                {
                    Debug.Log("готовим йогурт!");
                    GMScript1.cowMilk -= requiredNumberYogurt;
                    Debug.Log("коровьего молока: " + GMScript1.cowMilk);
                    startOneTimer = true;
                    slotArray[0] = 3;
                   
                }
                else
                {
                    if ((slotArray[0] == 0) || (imageSlotArray[0] == 0))
                    {
                        Debug.Log("готовим йогурт!");
                        GMScript1.cowMilk -= requiredNumberYogurt;
                        Debug.Log("коровьего молока: " + GMScript1.cowMilk);
                        startOneTimer = true;
                        slotArray[1] = 3;
                    }
                }
            }
        }
    }
    public void activatePopUpYogurt()
    {
        popUp.SetActive(true);
    }


    private void Update()
    {
       // if (startTimerCheese == true)
      //  {
     //       timerCheese += Time.fixedDeltaTime;
     //       if(timerCheese >= 10)
     //       {
     //           activatePopUpCheese();
     //           startTimerCheese = false;
     //           timerCheese = 0;
     //           boolCheese = true;
     //       }
     //   }

       // if (startTimerButter == true)
      //  {
         //   timerButter += Time.fixedDeltaTime;
         //   if (timerButter >= 10)
        //    {
      //          activatePopUpButter();
     //           startTimerButter = false;
    //            timerButter = 0;
     //           boolButter = true;
    //        }
    //    }

       // if (startTimerYogurt == true)
       // {
          //  timerYogurt += Time.fixedDeltaTime;
          //  if (timerYogurt >= 10)
          //  {
           //     activatePopUpYogurt();
           //     startTimerYogurt = false;
         //       timerYogurt = 0;
         //       boolYogurt = true;
         //   }
       // }


        if((slotArray[0] != 0) || (slotArray[1] != 0))
        {
            oneTimer += Time.deltaTime;
            if(oneTimer >= cheeseTimeToCook)
            {
                if ((slotArray[0] == 1) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUpCheese();
                    oneTimer = 0;
                    slotArray[0] = 0;
                    imageSlotArray[1] = 1;
                    second.GetComponent<SpriteRenderer>().sprite = cheeseIm;
                }

                if ((slotArray[0] == 1) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                {
                    startOneTimer = false;
                    activatePopUpCheese();
                    oneTimer = 0;
                    imageSlotArray[0] = 1;
                    first.GetComponent<SpriteRenderer>().sprite = cheeseIm;
                    slotArray[0] = slotArray[1];
                    slotArray[1] = 0;
                    if (slotArray[0] != 0)
                    {
                        startOneTimer = true;
                    }
                }

                if (oneTimer >= butterTimeToCook)
                {

                    if ((slotArray[0] == 2) && (imageSlotArray[0] != 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUpCheese();
                        oneTimer = 0;
                        slotArray[0] = 0;
                        imageSlotArray[1] = 2;
                        second.GetComponent<SpriteRenderer>().sprite = butterIm;
                    }

                    if ((slotArray[0] == 2) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUpButter();
                        oneTimer = 0;
                        imageSlotArray[0] = 2;
                        first.GetComponent<SpriteRenderer>().sprite = butterIm;
                        slotArray[0] = slotArray[1];
                        slotArray[1] = 0;
                        if (slotArray[0] != 0)
                        {
                            startOneTimer = true;
                        }
                    }

                }

                if (oneTimer >= yogurtTimeToCook)
                {

                    if ((slotArray[0] == 3) && (imageSlotArray[0] != 0) && (imageSlotArray[1] ==0))
                    {
                        startOneTimer = false;
                        activatePopUpCheese();
                        oneTimer = 0;
                        slotArray[0] = 0;
                        imageSlotArray[1] = 3;
                        second.GetComponent<SpriteRenderer>().sprite = yogurtIm;
                    }

                    if ((slotArray[0] == 3) && (imageSlotArray[0] == 0) && (imageSlotArray[1] == 0))
                    {
                        startOneTimer = false;
                        activatePopUpButter();
                        oneTimer = 0;
                        imageSlotArray[0] = 3;
                        first.GetComponent<SpriteRenderer>().sprite = yogurtIm;
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
        if((imageSlotArray[0] != 0) || (imageSlotArray[1] != 0))
        {
            popUp.SetActive(true);
        }
        if(imageSlotArray[0] == 0)
        {
            first.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (imageSlotArray[1] == 0)
        {
            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        
    }

    public Vector3 GetPosition()
    {
        throw new System.NotImplementedException();
        //Vector3 playerPosition = new Vector3(milkFactory.gameObject.transform.localPosition.x, milkFactory.gameObject.transform.localPosition.z, milkFactory.gameObject.transform.localPosition.z);
    }

    public void SetPosition(Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public int GetGoldAmount()
    {
        throw new System.NotImplementedException();
    }

    public void SetGoldAmount(int ImslotArFirstImage)
    {
        throw new System.NotImplementedException();
    }
    
}
