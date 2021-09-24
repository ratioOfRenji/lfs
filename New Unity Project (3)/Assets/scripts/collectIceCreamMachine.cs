using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collectIceCreamMachine : MonoBehaviour
{
    public GameObject first;
    public GameObject second;

    
    private void Start()
    {
        Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
    }
    private void OnMouseDown()
    {
        if (cookIceCream.imageSlotArray[1] == 1)
        {
            GMScript1.milkIceCream ++;
            Debug.Log("мороженного: " + GMScript1.milkIceCream + "шоколадного: " + GMScript1.chocholateIceCream + "фруктового: " + GMScript1.raspberryIceCream);
            cookIceCream.imageSlotArray[1] = 0;
            // this.gameObject.SetActive(false);

            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookIceCream.imageSlotArray[0] == 1)
        {
            GMScript1.milkIceCream++;
            Debug.Log("мороженного: " + GMScript1.milkIceCream + "шоколадного: " + GMScript1.chocholateIceCream + "фруктового: " + GMScript1.raspberryIceCream);
            cookIceCream.imageSlotArray[0] = 0;
            // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;

        }


        if (cookIceCream.imageSlotArray[1] == 2)
        {
            GMScript1.chocholateIceCream ++;
            Debug.Log("мороженного: " + GMScript1.milkIceCream + "шоколадного: " + GMScript1.chocholateIceCream + "фруктового: " + GMScript1.raspberryIceCream);
            cookIceCream.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookIceCream.imageSlotArray[0] == 2)
        {
            GMScript1.chocholateIceCream++;
            Debug.Log("мороженного: " + GMScript1.milkIceCream + "шоколадного: " + GMScript1.chocholateIceCream + "фруктового: " + GMScript1.raspberryIceCream);
            cookIceCream.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }

        if (cookIceCream.imageSlotArray[1] == 3)
        {
            GMScript1.raspberryIceCream++;
            Debug.Log("мороженного: " + GMScript1.milkIceCream + "шоколадного: " + GMScript1.chocholateIceCream + "фруктового: " + GMScript1.raspberryIceCream);
            cookIceCream.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookIceCream.imageSlotArray[0] == 3)
        {
            GMScript1.raspberryIceCream++;
            Debug.Log("мороженного: " + GMScript1.milkIceCream + "шоколадного: " + GMScript1.chocholateIceCream + "фруктового: " + GMScript1.raspberryIceCream);
            cookIceCream.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }
        this.gameObject.SetActive(false);
    }
}
