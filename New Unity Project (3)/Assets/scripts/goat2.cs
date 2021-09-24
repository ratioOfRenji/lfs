using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goat2 : MonoBehaviour
{
    public Sprite koza0;
    public Sprite koza1;
    public Sprite koza2;
    public Transform koza;
    void Update()
    {
        if ((GMScript1.kozuPokormili1 == false) && (GMScript1.kozuPokormili2 == false))
        {
            koza.GetComponent<SpriteRenderer>().sprite = koza0;

        }
        if (GMScript1.kozuPokormili1)
        {
            koza.GetComponent<SpriteRenderer>().sprite = koza1;

        }
        if (GMScript1.kozuPokormili2)
        {
            koza.GetComponent<SpriteRenderer>().sprite = koza2;
            GMScript1.kozuPokormili1 = false;

        }
    }
}
