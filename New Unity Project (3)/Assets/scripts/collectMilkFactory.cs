using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectMilkFactory : MonoBehaviour
{
    public GameObject first;
    public GameObject second;

    public Image cheese;
    public Image butter;
    public Image yogurt;
    private void Start()
    {
        Debug.Log("сыра: " + GMScript1.goatCheese+ "масла: " + GMScript1.butter+ "йогурта: " + GMScript1.yogurt);
    }
    private void OnMouseDown()
    {
        if (cookMilkFactory.imageSlotArray[1] == 1)
        {
            GMScript1.goatCheese++;
            Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookMilkFactory.imageSlotArray[1] = 0;
           // this.gameObject.SetActive(false);
            
            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookMilkFactory.imageSlotArray[0] == 1)
        {
            GMScript1.goatCheese++;
            Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookMilkFactory.imageSlotArray[0] = 0;
           // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;
            
        }


        if  (cookMilkFactory.imageSlotArray[1] == 2)
        {
            GMScript1.butter++;
            Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookMilkFactory.imageSlotArray[1] = 0;
            
            
            
            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookMilkFactory.imageSlotArray[0] == 2)
        {
            GMScript1.butter ++;
            Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookMilkFactory.imageSlotArray[0] = 0;
            
            first.GetComponent<SpriteRenderer>().sprite = null;
            

        }

        if (cookMilkFactory.imageSlotArray[1] == 3)
        {
            GMScript1.yogurt++;
            Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookMilkFactory.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookMilkFactory.imageSlotArray[0] == 3)
        {
            GMScript1.yogurt++;
            Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
            cookMilkFactory.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }
        this.gameObject.SetActive(false);
    }
}
