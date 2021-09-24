using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ammountOfFabrik : MonoBehaviour
{
    public Text fabricAmmount;
    void Update()
    {


        fabricAmmount.text = GMScript1.fabric.ToString();
    }
}
