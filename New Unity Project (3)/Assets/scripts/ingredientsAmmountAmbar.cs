using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingredientsAmmountAmbar : MonoBehaviour
{
    
    public Text wheatBreadAmmount;
    void Update()
    {

        
        wheatBreadAmmount.text = GMScript1.wheatBread.ToString();
    }

  
}
