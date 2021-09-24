using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammountOfNitki : MonoBehaviour
{
    public Text nitkiAmmount;
    void Update()
    {


        nitkiAmmount.text = GMScript1.nitki.ToString();
    }
}
