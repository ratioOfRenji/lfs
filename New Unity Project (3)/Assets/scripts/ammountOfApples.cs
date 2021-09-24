using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammountOfApples : MonoBehaviour
{
    public Text applesAmmount;
    void Update()
    {


        applesAmmount.text = GMScript1.apple.ToString();
    }
}
