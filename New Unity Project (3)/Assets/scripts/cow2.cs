using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow2 : MonoBehaviour
{
    public Sprite korova0;
    public Sprite korova1;
    public Sprite korova2;
    public Transform korova;
    void Update()
    {
        if ((GMScript1.korovuPokormili1 == false) && (GMScript1.korovuPokormili2 == false))
        {
            korova.GetComponent<SpriteRenderer>().sprite = korova0;

        }
        if (GMScript1.korovuPokormili1)
        {
            korova.GetComponent<SpriteRenderer>().sprite = korova1;

        }
        if (GMScript1.korovuPokormili2)
        {
            korova.GetComponent<SpriteRenderer>().sprite = korova2;
            GMScript1.korovuPokormili1 = false;

        }
    }
}
