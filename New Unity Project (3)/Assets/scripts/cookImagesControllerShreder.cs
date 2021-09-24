using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookImagesControllerShreder : MonoBehaviour
{
    public Sprite firstSlImIm;
    public Sprite secondSlIm;
    
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
        if (cookShreder.imageSlotArray[0] == 0)
        {
            if (cookShreder.slotArray[0] == 1)
            {
                first.sprite = firstSlImIm;
            }

            if (cookShreder.slotArray[0] == 2)
            {
                first.sprite = secondSlIm;
            }

            if (cookShreder.slotArray[1] == 1)
            {
                second.sprite = firstSlImIm;
            }

            if (cookShreder.slotArray[1] == 2)
            {
                second.sprite = secondSlIm;
            }
        }
        if ((cookShreder.imageSlotArray[0] != 0) && (cookShreder.slotArray[1] == 0))
        {
            if (cookShreder.slotArray[0] == 1)
            {
                second.sprite = firstSlImIm;
            }

            if (cookShreder.slotArray[0] == 2)
            {
                second.sprite = secondSlIm;
            }
        }

        if (cookShreder.imageSlotArray[0] == 1)
        {
            first.sprite = firstSlImIm;
        }

        if (cookShreder.imageSlotArray[0] == 2)
        {
            first.sprite = secondSlIm;
        }
        if (cookShreder.imageSlotArray[1] == 1)
        {
            second.sprite = firstSlImIm;
        }

        if (cookShreder.imageSlotArray[1] == 2)
        {
            second.sprite = secondSlIm;
        }

        if ((cookShreder.slotArray[0] == 0) && (cookShreder.imageSlotArray[0] == 0))
        {
            first.sprite = pustota;
        }

        if ((cookShreder.imageSlotArray[1] == 0) && (cookShreder.imageSlotArray[0] == 0) && (cookShreder.slotArray[1] == 0))
        {
            second.sprite = pustota;
        }
    }
}
