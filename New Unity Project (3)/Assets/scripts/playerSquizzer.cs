using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSquizzer : MonoBehaviour
{
    public GameObject building;
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookJuice.firstItemTimeToCook, cookJuice.secondItemTimeToCook, cookJuice.thirdItemTimeToCook };
    public int value;
    public PlayerData PlayerData { get; private set; }
    private void Start()
    {

    }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataSquizzer();
       cookJuice.oneTimer = PlayerData.oneTimerSquizzer;


       transform.position = PlayerData.LocationSquizzer;

       cookJuice.imageSlotArray = PlayerData.imSlotArraySquizzer;

       cookJuice.slotArray = PlayerData.slotArraySquizzer;
        if (PlayerData.valueForBoolSquizzer == 1)
        {
            building.GetComponent<dragAfterBought>().bought = true;
            building.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolSquizzer == 0)
        {
            building.GetComponent<dragAfterBought>().bought = false;
            building.GetComponent<dragAfterBought>().set = false;
        }
        value = cookJuice.slotArray[0];
        if ((cookJuice.slotArray[0] != 0) || (cookJuice.slotArray[1] != 0))
        {
            cookJuice.oneTimer = PlayerData.oneTimerGrill += TimeMaster.CheckDate();
            //  cookJuice.oneTimer = PlayerData.oneTimerSquizzer += TimeMaster.instance.CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookJuice.slotArray[0] != 0) && (cookJuice.slotArray[1] == 0))
        {
            float diference = TimeMaster.CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];

            cookJuice.oneTimer = PlayerData.oneTimerGrill += diferenceTwo;
            //float diference = TimeMaster.instance.CheckDate();
            //    float diferenceTwo = diference -= cookJuice.thirdItemTimeToCook;
            //   cookJuice.oneTimer = PlayerData.oneTimerSquizzer += diferenceTwo;
        }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataSquizzer(this);
    }
    private void Update()
    {
        OneTimer = cookJuice.oneTimer;
        slArZero = cookJuice.slotArray[0];
        slArOne = cookJuice.slotArray[1];
        imSlArZero = cookJuice.imageSlotArray[0];
        imSlArOne = cookJuice.imageSlotArray[1];
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
