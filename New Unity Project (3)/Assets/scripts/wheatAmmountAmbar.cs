using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wheatAmmountAmbar : MonoBehaviour
{
    public Text wheatAmmount;
    void Update()
    {


        wheatAmmount.text = GMScript1.sunFlowerSeeds.ToString();
    }
}

