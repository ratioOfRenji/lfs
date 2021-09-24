using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow1 : MonoBehaviour
{
    public float growTimeCow = 0;
    public Sprite korova1;

    private void OnMouseDown()
    {
        if (GMScript1.korovuPokormili1 == false)
        {
            if ((GMScript1.currentTool == "кормить") && (GMScript1.sunFlowerSeeds > 0))
            {
                GMScript1.korovuPokormili1 = true;
                GMScript1.sunFlowerSeeds--;
            }
            if ((GMScript1.currentTool == "кормить") && (GMScript1.korovuPokormili2))
            {
                GMScript1.korovuPokormili1 = false;
                GMScript1.korovuPokormili2 = false;
                GMScript1.cowMilk++;

                growTimeCow = 0;
            }
        }
    }
    private void Update()
    {
        if (GMScript1.korovuPokormili1)
        {
            growTimeCow += Time.deltaTime;
        }
        if (growTimeCow > 5)
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == korova1)
            {


                GMScript1.korovuPokormili2 = true;

            }
        }

    }
}
