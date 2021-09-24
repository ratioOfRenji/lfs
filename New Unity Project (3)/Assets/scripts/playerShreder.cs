using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShreder : MonoBehaviour
{
    public GameObject building;
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookShreder.sugarTimeToCook, cookShreder.coffeTimeToCook };
    public int value;
    public PlayerData PlayerData { get; private set; }
    private void Start()
    {

    }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataShreder();
        cookShreder.oneTimer = PlayerData.oneTimerShreder;


       transform.position = PlayerData.LocationShreder;

        cookShreder.imageSlotArray = PlayerData.imSlotArrayShreder;

        cookShreder.slotArray = PlayerData.slotArrayShreder;
        if (PlayerData.valueForBoolShreder == 1)
        {
            building.GetComponent<dragAfterBought>().bought = true;
            building.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolShreder == 0)
        {
            building.GetComponent<dragAfterBought>().bought = false;
            building.GetComponent<dragAfterBought>().set = false;
        }
        if ((cookShreder.slotArray[0] != 0) || (cookShreder.slotArray[1] != 0))
        {
            //  cookShreder.oneTimer = PlayerData.oneTimerShreder += TimeMaster.instance.CheckDate();
            cookShreder.oneTimer = PlayerData.oneTimerShreder += TimeMaster.CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookShreder.slotArray[0] != 0) && (cookShreder.slotArray[1] == 0))
        {
            //  float diference = TimeMaster.instance.CheckDate();
            //  float diferenceTwo = diference -= cookShreder.coffeTimeToCook;
            // cookShreder.oneTimer = PlayerData.oneTimerShreder += diferenceTwo;
            float diference = TimeMaster.CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];
            if (diference > 0)
            {
                cookShreder.oneTimer = PlayerData.oneTimerGrill += diferenceTwo;
            }
        }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataShreder(this);
    }
    private void Update()
    {
        OneTimer = cookShreder.oneTimer;
        slArZero = cookShreder.slotArray[0];
        slArOne = cookShreder.slotArray[1];
        imSlArZero = cookShreder.imageSlotArray[0];
        imSlArOne = cookShreder.imageSlotArray[1];
        if (building.GetComponent<dragAfterBought>().bought == true)
        {
            valueForBool = 1;
        }
        if (building.GetComponent<dragAfterBought>().bought == false)
        {
            valueForBool = 0;
        }




    }
}
