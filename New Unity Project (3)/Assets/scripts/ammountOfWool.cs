using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ammountOfWool : MonoBehaviour
{
    public Text woolAmmount;
    void Update()
    {


        woolAmmount.text = GMScript1.wool.ToString();
    }
}
