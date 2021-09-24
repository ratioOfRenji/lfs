using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammountOfOranges : MonoBehaviour
{
    public Text orangesAmmount;
    void Update()
    {


        orangesAmmount.text = GMScript1.orange.ToString();
    }
}
