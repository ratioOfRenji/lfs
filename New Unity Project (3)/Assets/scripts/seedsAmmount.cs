using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seedsAmmount : MonoBehaviour
{
    public Text[] seedsSlots;
    void Update()
    {


        seedsSlots[0].text = GMScript1.sunFlowerSeeds.ToString();
        seedsSlots[1].text = GMScript1.carrotSeeds.ToString();
        seedsSlots[2].text = GMScript1.potatoSeeds.ToString();
        seedsSlots[3].text = GMScript1.soySeeds.ToString();
        seedsSlots[4].text = GMScript1.sugarPlantSeeds.ToString();
    }
}
