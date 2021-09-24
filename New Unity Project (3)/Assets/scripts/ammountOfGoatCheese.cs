using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammountOfGoatCheese : MonoBehaviour
{

    public Text goatCheeseAmmount;
    void Update()
    {


        goatCheeseAmmount.text = GMScript1.goatCheese.ToString();
    }
}
