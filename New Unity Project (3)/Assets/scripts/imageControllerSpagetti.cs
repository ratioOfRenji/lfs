using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageControllerSpagetti : MonoBehaviour
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
        if (cookSpagettiMachine.imageSlotArray[0] == 0)
        {
            if (cookSpagettiMachine.slotArray[0] == 1)
            {
                first.sprite = firstImage;
            }

            if (cookSpagettiMachine.slotArray[0] == 2)
            {
                first.sprite = secondImage;
            }

            if (cookSpagettiMachine.slotArray[0] == 3)
            {
                first.sprite = thirdImage;
            }

            if (cookSpagettiMachine.slotArray[1] == 1)
            {
                second.sprite = firstImage;
            }

            if (cookSpagettiMachine.slotArray[1] == 2)
            {
                second.sprite = secondImage;
            }

            if (cookSpagettiMachine.slotArray[1] == 3)
            {
                second.sprite = thirdImage;
            }

        }
        if ((cookSpagettiMachine.imageSlotArray[0] != 0) && (cookSpagettiMachine.slotArray[1] == 0))
        {
            if (cookSpagettiMachine.slotArray[0] == 1)
            {
                second.sprite = firstImage;
            }

            if (cookSpagettiMachine.slotArray[0] == 2)
            {
                second.sprite = secondImage;
            }

            if (cookSpagettiMachine.slotArray[0] == 3)
            {
                second.sprite = thirdImage;
            }
        }

        if (cookSpagettiMachine.imageSlotArray[0] == 1)
        {
            first.sprite = firstImage;
        }

        if (cookSpagettiMachine.imageSlotArray[0] == 2)
        {
            first.sprite = secondImage;
        }

        if (cookSpagettiMachine.imageSlotArray[0] == 3)
        {
            first.sprite = thirdImage;
        }



        if (cookSpagettiMachine.imageSlotArray[1] == 1)
        {
            second.sprite = firstImage;
        }

        if (cookSpagettiMachine.imageSlotArray[1] == 2)
        {
            second.sprite = secondImage;
        }

        if (cookSpagettiMachine.imageSlotArray[1] == 3)
        {
            second.sprite = thirdImage;
        }

        if ((cookSpagettiMachine.slotArray[0] == 0) && (cookSpagettiMachine.imageSlotArray[0] == 0))
        {
            first.sprite = pustota;
        }

        if ((cookSpagettiMachine.imageSlotArray[1] == 0) && (cookSpagettiMachine.imageSlotArray[0] == 0) && (cookSpagettiMachine.slotArray[1] == 0))
        {
            second.sprite = pustota;
        }
    }
}
