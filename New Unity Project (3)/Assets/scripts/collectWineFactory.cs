using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectWineFactory : MonoBehaviour
{
    public GameObject first;
    public GameObject second;


    private void Start()
    {
        Debug.Log("вина: " + GMScript1.wine + "белого вина: " + GMScript1.whiteWine + "розового вина: " + GMScript1.pinkWine);
    }
    private void OnMouseDown()
    {
        if (cookWineFactory.imageSlotArray[1] == 1)
        {
            GMScript1.wine++;
            Debug.Log("вина: " + GMScript1.wine + "белого вина: " + GMScript1.whiteWine + "розового вина: " + GMScript1.pinkWine);
            cookWineFactory.imageSlotArray[1] = 0;
            // this.gameObject.SetActive(false);

            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookWineFactory.imageSlotArray[0] == 1)
        {
            GMScript1.wine++;
            Debug.Log("вина: " + GMScript1.wine + "белого вина: " + GMScript1.whiteWine + "розового вина: " + GMScript1.pinkWine);
            cookWineFactory.imageSlotArray[0] = 0;
            // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;

        }


        if (cookWineFactory.imageSlotArray[1] == 2)
        {
            GMScript1.whiteWine++;
            Debug.Log("вина: " + GMScript1.wine + "белого вина: " + GMScript1.whiteWine + "розового вина: " + GMScript1.pinkWine);
            cookWineFactory.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookWineFactory.imageSlotArray[0] == 2)
        {
            GMScript1.whiteWine++;
            Debug.Log("вина: " + GMScript1.wine + "белого вина: " + GMScript1.whiteWine + "розового вина: " + GMScript1.pinkWine);
            cookWineFactory.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }

        if (cookWineFactory.imageSlotArray[1] == 3)
        {
            GMScript1.pinkWine++;
            Debug.Log("вина: " + GMScript1.wine + "белого вина: " + GMScript1.whiteWine + "розового вина: " + GMScript1.pinkWine);
            cookWineFactory.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookWineFactory.imageSlotArray[0] == 3)
        {
            GMScript1.pinkWine++;
            Debug.Log("вина: " + GMScript1.wine + "белого вина: " + GMScript1.whiteWine + "розового вина: " + GMScript1.pinkWine);
            cookWineFactory.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }
        this.gameObject.SetActive(false);
    }
}
