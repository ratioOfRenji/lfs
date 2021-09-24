using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheep2 : MonoBehaviour
{
    public Sprite sheep0;
    public Sprite sheep1;
    public Sprite sheeep2;
    public Transform sheep;
    void Update()
    {
        if ((GMScript1.ovtsuPokormili1 == false) && (GMScript1.ovtsuPokormili2 == false))
        {
            sheep.GetComponent<SpriteRenderer>().sprite = sheep0;

        }
        if (GMScript1.ovtsuPokormili1)
        {
            sheep.GetComponent<SpriteRenderer>().sprite = sheep1;

        }
        if (GMScript1.ovtsuPokormili2)
        {
            sheep.GetComponent<SpriteRenderer>().sprite = sheeep2;
            GMScript1.ovtsuPokormili1 = false;

        }
    }
}
