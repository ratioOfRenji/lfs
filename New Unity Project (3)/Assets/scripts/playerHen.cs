using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHen : MonoBehaviour
{
   
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookSpagettiMachine.firstItemTimeToCook, cookSpagettiMachine.secondItemTimeToCook, cookSpagettiMachine.thirdItemTimeToCook };
    public int value;
    
    public animalsData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataHen();
      


       transform.position = PlayerData.LocationHen;
      
      
        if (PlayerData.valueForBoolHen == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolHen == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        
    }
   
    private void OnDisable()
    {
        playerPrefAnimals.SaveDataHen(this);
    }
    private void Update()
    {
      
        if (this.gameObject.GetComponent<dragAfterBought>().bought == true)
        {
            valueForBool = 1;
        }
        if (this.gameObject.GetComponent<dragAfterBought>().bought == false)
        {
            valueForBool = 0;
        }


    }
}
