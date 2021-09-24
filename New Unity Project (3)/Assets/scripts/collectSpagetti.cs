using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectSpagetti : MonoBehaviour
{
    public GameObject first;
    public GameObject second;


    private void Start()
    {
        Debug.Log("сыра: " + GMScript1.goatCheese + "масла: " + GMScript1.butter + "йогурта: " + GMScript1.yogurt);
    }
    private void OnMouseDown()
    {
        if (cookSpagettiMachine.imageSlotArray[1] == 1)
        {
            GMScript1.darkSpagetti++;
            Debug.Log("темных спагетти: " + GMScript1.darkSpagetti + "спагетти: " + GMScript1.spagetti + "цветных спагетти: " + GMScript1.coloredSpagetti);
            cookSpagettiMachine.imageSlotArray[1] = 0;
            // this.gameObject.SetActive(false);

            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookSpagettiMachine.imageSlotArray[0] == 1)
        {
            GMScript1.darkSpagetti++;
            Debug.Log("темных спагетти: " + GMScript1.darkSpagetti + "спагетти: " + GMScript1.spagetti + "цветных спагетти: " + GMScript1.coloredSpagetti);
            cookSpagettiMachine.imageSlotArray[0] = 0;
            // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;

        }


        if (cookSpagettiMachine.imageSlotArray[1] == 2)
        {
            GMScript1.spagetti++;
            Debug.Log("темных спагетти: " + GMScript1.darkSpagetti + "спагетти: " + GMScript1.spagetti + "цветных спагетти: " + GMScript1.coloredSpagetti);
            cookSpagettiMachine.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookSpagettiMachine.imageSlotArray[0] == 2)
        {
            GMScript1.spagetti++;
            Debug.Log("темных спагетти: " + GMScript1.darkSpagetti + "спагетти: " + GMScript1.spagetti + "цветных спагетти: " + GMScript1.coloredSpagetti);
            cookSpagettiMachine.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }

        if (cookSpagettiMachine.imageSlotArray[1] == 3)
        {
            GMScript1.coloredSpagetti++;
            Debug.Log("темных спагетти: " + GMScript1.darkSpagetti + "спагетти: " + GMScript1.spagetti + "цветных спагетти: " + GMScript1.coloredSpagetti);
            cookSpagettiMachine.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookSpagettiMachine.imageSlotArray[0] == 3)
        {
            GMScript1.coloredSpagetti++;
            Debug.Log("темных спагетти: " + GMScript1.darkSpagetti + "спагетти: " + GMScript1.spagetti + "цветных спагетти: " + GMScript1.coloredSpagetti);
            cookSpagettiMachine.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }
        this.gameObject.SetActive(false);
    }
}
