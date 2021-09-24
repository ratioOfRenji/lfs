using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaytsa : MonoBehaviour
{
    public float growTime = 0;
    public Sprite kuritsa1;

    private void OnMouseDown()
    {
        if ((GMScript1.currentTool == "кормить") && (GMScript1.sunFlowerSeeds > 0))
        {
            GMScript1.kuritsuPokormili1 = true;
            GMScript1.sunFlowerSeeds--;
        }
        if ((GMScript1.currentTool == "кормить") && (GMScript1.kuritsuPokormili2))
        {
            GMScript1.kuritsuPokormili1 = false;
            GMScript1.kuritsuPokormili2 = false;
            GMScript1.yaytsa++;
            Debug.Log("у тебя яиц" + GMScript1.yaytsa);
            growTime = 0;
        }
    }
    private void Update()
    {
        if (GMScript1.kuritsuPokormili1)
        {
            growTime += Time.deltaTime;
        }
        if (growTime > 5)
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == kuritsa1)
            {

                
                GMScript1.kuritsuPokormili2 = true;

            }
        }

    }
}
