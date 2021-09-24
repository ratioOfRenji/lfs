using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectGrill : MonoBehaviour
{
    public GameObject first;
    public GameObject second;


    private void Start()
    {
        //Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
    }
    private void OnMouseDown()
    {
        if (cookGrill.imageSlotArray[1] == 1)
        {
            GMScript1.cheeseSandwich++;
            Debug.Log("сырных сэндвичей: " + GMScript1.cheeseSandwich + "томатных сэндвичей: " + GMScript1.tomatoSandwich + "апельсиновых пирогов: " + GMScript1.orangeCake);
            cookGrill.imageSlotArray[1] = 0;
            // this.gameObject.SetActive(false);

            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookGrill.imageSlotArray[0] == 1)
        {
            GMScript1.cheeseSandwich++;
            Debug.Log("сырных сэндвичей: " + GMScript1.cheeseSandwich + "томатных сэндвичей: " + GMScript1.tomatoSandwich + "апельсиновых пирогов: " + GMScript1.orangeCake);
            cookGrill.imageSlotArray[0] = 0;
            // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;

        }


        if (cookGrill.imageSlotArray[1] == 2)
        {
            GMScript1.tomatoSandwich++;
            Debug.Log("сырных сэндвичей: " + GMScript1.cheeseSandwich + "томатных сэндвичей: " + GMScript1.tomatoSandwich + "апельсиновых пирогов: " + GMScript1.orangeCake);
            cookGrill.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookGrill.imageSlotArray[0] == 2)
        {
            GMScript1.tomatoSandwich++;
            Debug.Log("сырных сэндвичей: " + GMScript1.cheeseSandwich + "томатных сэндвичей: " + GMScript1.tomatoSandwich + "апельсиновых пирогов: " + GMScript1.orangeCake);
            cookGrill.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }

        if (cookGrill.imageSlotArray[1] == 3)
        {
            GMScript1.orangeCake++;
            Debug.Log("сырных сэндвичей: " + GMScript1.cheeseSandwich + "томатных сэндвичей: " + GMScript1.tomatoSandwich + "апельсиновых пирогов: " + GMScript1.orangeCake);
            cookGrill.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookGrill.imageSlotArray[0] == 3)
        {
            GMScript1.orangeCake++;
            Debug.Log("сырных сэндвичей: " + GMScript1.cheeseSandwich + "томатных сэндвичей: " + GMScript1.tomatoSandwich + "апельсиновых пирогов: " + GMScript1.orangeCake);
            cookGrill.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }
        this.gameObject.SetActive(false);
    }
}
