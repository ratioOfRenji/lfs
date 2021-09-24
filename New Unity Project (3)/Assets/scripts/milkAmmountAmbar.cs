using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class milkAmmountAmbar : MonoBehaviour
{
    public Text milkAmmount;
    void Update()
    {


        milkAmmount.text = GMScript1.cowMilk.ToString();
    }
}
