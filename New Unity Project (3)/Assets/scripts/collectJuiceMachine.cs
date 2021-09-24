using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectJuiceMachine : MonoBehaviour
{
    public GameObject first;
    public GameObject second;


    private void Start()
    {
        Debug.Log("яблочного сока: " + GMScript1.appleJuice + "виноградного сока: " + GMScript1.grapeJuice + "вишневого сока: " + GMScript1.cherryJuice);
    }
    private void OnMouseDown()
    {
        if (cookJuice.imageSlotArray[1] == 1)
        {
            GMScript1.appleJuice++;
            Debug.Log("яблочного сока: " + GMScript1.appleJuice + "виноградного сока: " + GMScript1.grapeJuice + "вишневого сока: " + GMScript1.cherryJuice);
            cookJuice.imageSlotArray[1] = 0;
            // this.gameObject.SetActive(false);

            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookJuice.imageSlotArray[0] == 1)
        {
            GMScript1.appleJuice++;
            Debug.Log("яблочного сока: " + GMScript1.appleJuice + "виноградного сока: " + GMScript1.grapeJuice + "вишневого сока: " + GMScript1.cherryJuice);
            cookJuice.imageSlotArray[0] = 0;
            // this.gameObject.SetActive(false);
            first.GetComponent<SpriteRenderer>().sprite = null;

        }


        if (cookJuice.imageSlotArray[1] == 2)
        {
            GMScript1.grapeJuice++;
            Debug.Log("яблочного сока: " + GMScript1.appleJuice + "виноградного сока: " + GMScript1.grapeJuice + "вишневого сока: " + GMScript1.cherryJuice);
            cookJuice.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookJuice.imageSlotArray[0] == 2)
        {
            GMScript1.grapeJuice++;
            Debug.Log("яблочного сока: " + GMScript1.appleJuice + "виноградного сока: " + GMScript1.grapeJuice + "вишневого сока: " + GMScript1.cherryJuice);
            cookJuice.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }

        if (cookJuice.imageSlotArray[1] == 3)
        {
            GMScript1.cherryJuice++;
            Debug.Log("яблочного сока: " + GMScript1.appleJuice + "виноградного сока: " + GMScript1.grapeJuice + "вишневого сока: " + GMScript1.cherryJuice);
            cookJuice.imageSlotArray[1] = 0;



            second.GetComponent<SpriteRenderer>().sprite = null;
        }
        if (cookJuice.imageSlotArray[0] == 3)
        {
            GMScript1.cherryJuice++;
            Debug.Log("яблочного сока: " + GMScript1.appleJuice + "виноградного сока: " + GMScript1.grapeJuice + "вишневого сока: " + GMScript1.cherryJuice);
            cookJuice.imageSlotArray[0] = 0;

            first.GetComponent<SpriteRenderer>().sprite = null;


        }
        this.gameObject.SetActive(false);
    }
}
