using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookImagesController : MonoBehaviour
{
    public Sprite cheeseIm;
    public Sprite butterIm;
    public Sprite yogurtIm;
    public Sprite pustota;



    public Image first;
    public Image second;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(cookMilkFactory.imageSlotArray[0] == 0)
        {
            if(cookMilkFactory.slotArray[0] == 1)
            {
                first.sprite = cheeseIm;
            }

            if (cookMilkFactory.slotArray[0] == 2)
            {
                first.sprite = butterIm;
            }

            if (cookMilkFactory.slotArray[0] == 3)
            {
                first.sprite = yogurtIm;
            }

            if (cookMilkFactory.slotArray[1] == 1)
            {
                second.sprite = cheeseIm;
            }

            if (cookMilkFactory.slotArray[1] == 2)
            {
                second.sprite = butterIm;
            }

            if (cookMilkFactory.slotArray[1] == 3)
            {
                second.sprite = yogurtIm;
            }

        }
       if((cookMilkFactory.imageSlotArray[0] != 0) && (cookMilkFactory.slotArray[1] == 0))
        {
            if(cookMilkFactory.slotArray[0] == 1)
            {
                second.sprite = cheeseIm;
            }

            if (cookMilkFactory.slotArray[0] == 2)
            {
                second.sprite = butterIm;
            }

            if (cookMilkFactory.slotArray[0] == 3)
            {
                second.sprite = yogurtIm;
            }
        }

       if (cookMilkFactory.imageSlotArray[0] == 1)
        {
            first.sprite = cheeseIm;
        }

        if (cookMilkFactory.imageSlotArray[0] == 2)
        {
            first.sprite = butterIm;
        }

        if (cookMilkFactory.imageSlotArray[0] == 3)
        {
            first.sprite = yogurtIm;
        }



        if (cookMilkFactory.imageSlotArray[1] == 1)
        {
            second.sprite = cheeseIm;
        }

        if (cookMilkFactory.imageSlotArray[1] == 2)
        {
            second.sprite = butterIm;
        }

        if (cookMilkFactory.imageSlotArray[1] == 3)
        {
            second.sprite = yogurtIm;
        }

        if((cookMilkFactory.slotArray[0] == 0) &&(cookMilkFactory.imageSlotArray[0] == 0))
        {
            first.sprite = pustota;
        }

        if((cookMilkFactory.imageSlotArray[1] == 0) && (cookMilkFactory.imageSlotArray[0] == 0) &&( cookMilkFactory.slotArray[1] ==0))
        {
            second.sprite = pustota;
        }
    }
}
