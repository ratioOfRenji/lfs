using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpagetti : MonoBehaviour
{
    public cookSpagettiMachine cookSpagettiMachine;
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookSpagettiMachine.firstItemTimeToCook, cookSpagettiMachine.secondItemTimeToCook, cookSpagettiMachine.thirdItemTimeToCook };
    public int value;
    
    public PlayerData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataSpagetti();
      cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti;


       transform.position = PlayerData.LocationSpagetti;
        // cookMilkFactory = this.gameObject.GetComponent<cookMilkFactory>();
        cookSpagettiMachine.imageSlotArray = PlayerData.imSlotArraySpagetti;

        cookSpagettiMachine.slotArray = PlayerData.slotArraySpagetti;
        if (PlayerData.valueForBoolSpagetti == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolSpagetti == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        value = cookSpagettiMachine.slotArray[0];
        if ((cookSpagettiMachine.slotArray[0] != 0) || (cookSpagettiMachine.slotArray[1] != 0))
        {
            cookSpagettiMachine.oneTimer = PlayerData.oneTimerGrill += TimeMaster.CheckDate();
            // cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti += TimeMaster.instance.CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookSpagettiMachine.slotArray[0] != 0) && (cookSpagettiMachine.slotArray[1] == 0))
        {
            float diference = TimeMaster.CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];

            cookSpagettiMachine.oneTimer = PlayerData.oneTimerGrill += diferenceTwo;
            //  float diference = TimeMaster.instance.CheckDate();
            //  float diferenceTwo = diference -= cookSpagettiMachine.thirdItemTimeToCook;
            //   cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti += diferenceTwo;
        }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataSpagetti(this);
    }
    private void Update()
    {
        OneTimer =cookSpagettiMachine.oneTimer;
        slArZero = cookSpagettiMachine.slotArray[0];
        slArOne = cookSpagettiMachine.slotArray[1];
        imSlArZero = cookSpagettiMachine.imageSlotArray[0];
        imSlArOne = cookSpagettiMachine.imageSlotArray[1];
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
