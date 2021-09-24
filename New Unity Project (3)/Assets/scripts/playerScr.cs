using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScr : MonoBehaviour
{
    public cookMilkFactory cookMilkFactory;
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookMilkFactory.cheeseTimeToCook, cookMilkFactory.butterTimeToCook, cookMilkFactory.yogurtTimeToCook };
    public int value;
    public PlayerData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadData();
         cookMilkFactory.oneTimer = PlayerData.oneTimer;
       
       
        transform.position = PlayerData.Location;
        cookMilkFactory = this.gameObject.GetComponent<cookMilkFactory>();
       cookMilkFactory.imageSlotArray = PlayerData.imSlotArray;
 
       cookMilkFactory.slotArray = PlayerData.slotArray;
        if (PlayerData.valueForBoolMilkFacory == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolMilkFacory == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        value = cookMilkFactory.slotArray[0];
        if ((cookMilkFactory.slotArray[0]!= 0) || (cookMilkFactory.slotArray[1] != 0))
        {
          cookMilkFactory.oneTimer = PlayerData.oneTimer += TimeMaster.CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    { 
        yield return new WaitForSeconds(2);
      if ((cookMilkFactory.slotArray[0] != 0) && (cookMilkFactory.slotArray[1] == 0))
       {
            float diference = TimeMaster.CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];
            if(diference > 0)
            {
            cookMilkFactory.oneTimer = PlayerData.oneTimer += diferenceTwo; }
        }
      
    }
    private void OnDisable()
    {
        playerPrefsData.SaveData(this);
    }
    private void Update()
    {
      OneTimer = cookMilkFactory.oneTimer;
      slArZero = cookMilkFactory.slotArray[0];
      slArOne = cookMilkFactory.slotArray[1];
        imSlArZero = cookMilkFactory.imageSlotArray[0];
        imSlArOne = cookMilkFactory.imageSlotArray[1];
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
