using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookImageControllerBakery : MonoBehaviour
{
    public Sprite cheeseIm;
    public Sprite butterIm;
   // public Sprite yogurtIm;
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
        if (cookBakery.imageSlotArray[0] == 0)
        {
            if (cookBakery.slotArray[0] == 1)
            {
                first.sprite = cheeseIm;
            }

            if (cookBakery.slotArray[0] == 2)
            {
                first.sprite = butterIm;
            }

            

            if (cookBakery.slotArray[1] == 1)
            {
                second.sprite = cheeseIm;
            }

            if (cookBakery.slotArray[1] == 2)
            {
                second.sprite = butterIm;
            }

           

        }
        if ((cookBakery.imageSlotArray[0] != 0) && (cookBakery.slotArray[1] == 0))
        {
            if (cookBakery.slotArray[0] == 1)
            {
                second.sprite = cheeseIm;
            }

            if (cookBakery.slotArray[0] == 2)
            {
                second.sprite = butterIm;
            }

            
        }

        if (cookBakery.imageSlotArray[0] == 1)
        {
            first.sprite = cheeseIm;
        }

        if (cookBakery.imageSlotArray[0] == 2)
        {
            first.sprite = butterIm;
        }

       



        if (cookBakery.imageSlotArray[1] == 1)
        {
            second.sprite = cheeseIm;
        }

        if (cookBakery.imageSlotArray[1] == 2)
        {
            second.sprite = butterIm;
        }

       

        if ((cookBakery.slotArray[0] == 0) && (cookBakery.imageSlotArray[0] == 0))
        {
            first.sprite = pustota;
        }

        if ((cookBakery.imageSlotArray[1] == 0) && (cookBakery.imageSlotArray[0] == 0) && (cookBakery.slotArray[1] == 0))
        {
            second.sprite = pustota;
        }
    }
}
