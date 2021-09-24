using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectBakery : MonoBehaviour
{
    public GameObject first;
    public GameObject second;

    //public Image cheese;
    //public Image butter;
    //public Image yogurt;
    private void Start()
    {
        //Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
    }
    private void OnMouseDown()
    {
        if (cookBakery.imageSlotArray[1] == 1)
        {
            GMScript1.wheatBread++;
            //Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookBakery.imageSlotArray[1] = 0;
            // this.gameObject.SetActive(false);

            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookBakery.imageSlotArray[0] == 1)
        {
            GMScript1.wheatBread++;
            //Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookBakery.imageSlotArray[0] = 0;
            // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;

        }


        if (cookBakery.imageSlotArray[1] == 2)
        {
            GMScript1.whiteBreat++;
            //Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookBakery.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookBakery.imageSlotArray[0] == 2)
        {
            GMScript1.whiteBreat++;
            //Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookBakery.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }

        //if (cookBakery.imageSlotArray[1] == 3)
        //{
        //    GMScript1.yogurt++;
        //    //Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
        //    cookBakery.imageSlotArray[1] = 0;



        //    second.GetComponent<SpriteRenderer>().sprite = null;
        //}
        //if (cookBakery.imageSlotArray[0] == 3)
        //{
        //    GMScript1.yogurt++;
        //    //  Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
        //    cookBakery.imageSlotArray[0] = 0;

        //    first.GetComponent<SpriteRenderer>().sprite = null;


        //}
        this.gameObject.SetActive(false);
    }
}
