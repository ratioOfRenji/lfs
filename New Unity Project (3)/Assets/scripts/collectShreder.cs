using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectShreder : MonoBehaviour
{
    public GameObject first;
    public GameObject second;

    
    private void Start()
    {
        Debug.Log("сахара: " + GMScript1.sugar + "кофе: " + GMScript1.coffee);
    }
    private void OnMouseDown()
    {
        if (cookShreder.imageSlotArray[1] == 1)
        {
            GMScript1.sugar++;
            Debug.Log("сахара: " + GMScript1.sugar + "кофе: " + GMScript1.coffee);
            cookShreder.imageSlotArray[1] = 0;
            // this.gameObject.SetActive(false);

            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookShreder.imageSlotArray[0] == 1)
        {
            GMScript1.sugar++;
            Debug.Log("сахара: " + GMScript1.sugar + "кофе: " + GMScript1.coffee);
            cookShreder.imageSlotArray[0] = 0;
            // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;

        }


        if (cookShreder.imageSlotArray[1] == 2)
        {
            GMScript1.coffee++;
            Debug.Log("сахара: " + GMScript1.sugar + "кофе: " + GMScript1.coffee);
            cookShreder.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookShreder.imageSlotArray[0] == 2)
        {
            GMScript1.coffee++;
            Debug.Log("сахара: " + GMScript1.sugar + "кофе: " + GMScript1.coffee);
            cookShreder.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }

       
        this.gameObject.SetActive(false);
    }
}
