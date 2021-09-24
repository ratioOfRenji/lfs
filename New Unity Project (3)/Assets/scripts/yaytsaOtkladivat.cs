using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaytsaOtkladivat : MonoBehaviour
{
    public Sprite kuritsa0;
    public Sprite kuritsa1;
    public Sprite kuritsa2;
    public Transform kuritsa;
    void Update()
    {
        if ((GMScript1.kuritsuPokormili1 == false) && (GMScript1.kuritsuPokormili2 == false))
        {
            kuritsa.GetComponent<SpriteRenderer>().sprite = kuritsa0;

        }
        if (GMScript1.kuritsuPokormili1)
        {
            kuritsa.GetComponent<SpriteRenderer>().sprite = kuritsa1;
            
        }
        if (GMScript1.kuritsuPokormili2)
        {
            kuritsa.GetComponent<SpriteRenderer>().sprite = kuritsa2;
            GMScript1.kuritsuPokormili1 = false;

        }
    }
}
