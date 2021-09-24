using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carrotPotatoAmmountShow : MonoBehaviour
{
    public Text carrotSeeds;
    public Text potatoSeeds;
    public Text sunflowerSeeds;
    public Text wheatBreadAmmount;
    void Update()
    {
       
        carrotSeeds.text = GMScript1.carrotSeeds.ToString();
        potatoSeeds.text = GMScript1.potatoSeeds.ToString();
        sunflowerSeeds.text = GMScript1.potatoSeeds.ToString();
        wheatBreadAmmount.text = GMScript1.wheatBread.ToString();
    }
}
