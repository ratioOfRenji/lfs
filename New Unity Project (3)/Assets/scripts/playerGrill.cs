using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGrill : MonoBehaviour
{
    public GameObject building;
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookGrill.firstItemTimeToCook, cookGrill.secondItemTimeToCook, cookGrill.thirdItemTimeToCook };
    public int value;
    public PlayerData PlayerData { get; private set; }
    private void Start()
    {
      
    }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataGrill();
      cookGrill.oneTimer = PlayerData.oneTimerGrill;


        transform.position = PlayerData.LocationGrill;
        
       cookGrill.imageSlotArray = PlayerData.imSlotArrayGrill;
       
       cookGrill.slotArray = PlayerData.slotArrayGrill;
        if(PlayerData.valueForBoolGrill ==1)
        {
            building.GetComponent<dragAfterBought>().bought = true;
            building.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolGrill == 0)
        {
            building.GetComponent<dragAfterBought>().bought = false;
            building.GetComponent<dragAfterBought>().set = false;
        }
        value = cookGrill.slotArray[0];
       if ((cookGrill.slotArray[0] != 0) || (cookGrill.slotArray[1] != 0))
       {
             cookGrill.oneTimer = PlayerData.oneTimerGrill += TimeMaster.CheckDate();
          //  Debug.Log("qwe" + worldTimer._worldTimer);
         // cookGrill.oneTimer = PlayerData.oneTimerGrill += worldTimer._worldTimer;
        }
        StartCoroutine(waitBeforeStop());
    }
   IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookGrill.slotArray[0] != 0) && (cookGrill.slotArray[1] == 0))
       {
           float diference = TimeMaster.CheckDate();
          float diferenceTwo = diference -= reqTimers[value - 1];
           if(diferenceTwo > 0)
            { 
           cookGrill.oneTimer = PlayerData.oneTimerGrill += diferenceTwo;
           }
       }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataGrill(this);
    }
    private void Update()
    {
        OneTimer = cookGrill.oneTimer;
        slArZero = cookGrill.slotArray[0];
        slArOne = cookGrill.slotArray[1];
        imSlArZero = cookGrill.imageSlotArray[0];
        imSlArOne = cookGrill.imageSlotArray[1];
        if (building.GetComponent<dragAfterBought>().bought == true)
        {
            valueForBool = 1;
        }
        if (building.GetComponent<dragAfterBought>().bought == false)
        {
            valueForBool = 0;
        }

       // Debug.Log("rty" + worldTimer._worldTimer);


    }
}
