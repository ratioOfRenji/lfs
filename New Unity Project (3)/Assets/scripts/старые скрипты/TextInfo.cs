using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "sunflowerTxt")
        {
            GetComponent<TextMesh>().text = "Sunflower Seeds :" + GMScript1.sunFlowerSeeds;
        }
        if (gameObject.name == "морковка")
        {
            GetComponent<TextMesh>().text = "Carrot Seeds :" + GMScript1.carrotSeeds;
        }
        if (gameObject.name == "potatoTxt")
        {
            GetComponent<TextMesh>().text = "Potato Seeds :" + GMScript1.potatoSeeds;
        }
        if (gameObject.name == "moneyAmmount")
        {
            GetComponent<TextMesh>().text = "" + GMScript1.money;
        }
    }
    private void OnMouseDown()
    {
        if (gameObject.name == "sunflowerTxt")
        {
            GMScript1.currentTool = "sunflower";
        }
        if (gameObject.name == "морковка")
        {
            GMScript1.currentTool = "carrot";
        }
        if (gameObject.name == "potatoTxt")
        {
            GMScript1.currentTool = "potato";
        }
    }
}
