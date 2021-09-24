using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookImagesControllerWineFactory : MonoBehaviour
{
    public Sprite firstIm;
    public Sprite secondIm;
    public Sprite thirdIm;
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
        if (cookWineFactory.imageSlotArray[0] == 0)
        {
            if (cookWineFactory.slotArray[0] == 1)
            {
                first.sprite = firstIm;
            }

            if (cookWineFactory.slotArray[0] == 2)
            {
                first.sprite = secondIm;
            }

            if (cookWineFactory.slotArray[0] == 3)
            {
                first.sprite = thirdIm;
            }

            if (cookWineFactory.slotArray[1] == 1)
            {
                second.sprite = firstIm;
            }

            if (cookWineFactory.slotArray[1] == 2)
            {
                second.sprite = secondIm;
            }

            if (cookWineFactory.slotArray[1] == 3)
            {
                second.sprite = thirdIm;
            }

        }
        if ((cookWineFactory.imageSlotArray[0] != 0) && (cookWineFactory.slotArray[1] == 0))
        {
            if (cookWineFactory.slotArray[0] == 1)
            {
                second.sprite = firstIm;
            }

            if (cookWineFactory.slotArray[0] == 2)
            {
                second.sprite = secondIm;
            }

            if (cookWineFactory.slotArray[0] == 3)
            {
                second.sprite = thirdIm;
            }
        }

        if (cookWineFactory.imageSlotArray[0] == 1)
        {
            first.sprite = firstIm;
        }

        if (cookWineFactory.imageSlotArray[0] == 2)
        {
            first.sprite = secondIm;
        }

        if (cookWineFactory.imageSlotArray[0] == 3)
        {
            first.sprite = thirdIm;
        }



        if (cookWineFactory.imageSlotArray[1] == 1)
        {
            second.sprite = firstIm;
        }

        if (cookWineFactory.imageSlotArray[1] == 2)
        {
            second.sprite = secondIm;
        }

        if (cookWineFactory.imageSlotArray[1] == 3)
        {
            second.sprite = thirdIm;
        }

        if ((cookWineFactory.slotArray[0] == 0) && (cookWineFactory.imageSlotArray[0] == 0))
        {
            first.sprite = pustota;
        }

        if ((cookWineFactory.imageSlotArray[1] == 0) && (cookWineFactory.imageSlotArray[0] == 0) && (cookWineFactory.slotArray[1] == 0))
        {
            second.sprite = pustota;
        }
    }
}
