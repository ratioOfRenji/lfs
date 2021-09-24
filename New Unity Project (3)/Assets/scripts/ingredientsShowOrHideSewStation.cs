using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredientsShowOrHideSewStation : MonoBehaviour
{
    public GameObject wool;
    public GameObject nitki;

    // Update is called once per frame
    void Update()
    {
        if (GMScript1.wool > 0)
        {
            wool.SetActive(true);
        }
        if (GMScript1.nitki > 0)
        {
           nitki.SetActive(true);
        }
        if (GMScript1.wool <= 0)
        {
            wool.SetActive(false);
        }
        if (GMScript1.nitki <= 0)
        {
           nitki.SetActive(false);
        }
    }
}
