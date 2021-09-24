using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookImagesControllerJuiceMachine : MonoBehaviour
{
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
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
        if (cookJuice.imageSlotArray[0] == 0)
        {
            if (cookJuice.slotArray[0] == 1)
            {
                first.sprite = firstImage;
            }

            if (cookJuice.slotArray[0] == 2)
            {
                first.sprite = secondImage;
            }

            if (cookJuice.slotArray[0] == 3)
            {
                first.sprite = thirdImage;
            }

            if (cookJuice.slotArray[1] == 1)
            {
                second.sprite = firstImage;
            }

            if (cookJuice.slotArray[1] == 2)
            {
                second.sprite = secondImage;
            }

            if (cookJuice.slotArray[1] == 3)
            {
                second.sprite = thirdImage;
            }

        }
        if ((cookJuice.imageSlotArray[0] != 0) && (cookJuice.slotArray[1] == 0))
        {
            if (cookJuice.slotArray[0] == 1)
            {
                second.sprite = firstImage;
            }

            if (cookJuice.slotArray[0] == 2)
            {
                second.sprite = secondImage;
            }

            if (cookJuice.slotArray[0] == 3)
            {
                second.sprite = thirdImage;
            }
        }

        if (cookJuice.imageSlotArray[0] == 1)
        {
            first.sprite = firstImage;
        }

        if (cookJuice.imageSlotArray[0] == 2)
        {
            first.sprite = secondImage;
        }

        if (cookJuice.imageSlotArray[0] == 3)
        {
            first.sprite = thirdImage;
        }



        if (cookJuice.imageSlotArray[1] == 1)
        {
            second.sprite = firstImage;
        }

        if (cookJuice.imageSlotArray[1] == 2)
        {
            second.sprite = secondImage;
        }

        if (cookJuice.imageSlotArray[1] == 3)
        {
            second.sprite = thirdImage;
        }

        if ((cookJuice.slotArray[0] == 0) && (cookJuice.imageSlotArray[0] == 0))
        {
            first.sprite = pustota;
        }

        if ((cookJuice.imageSlotArray[1] == 0) && (cookJuice.imageSlotArray[0] == 0) && (cookJuice.slotArray[1] == 0))
        {
            second.sprite = pustota;
        }
    }
}
