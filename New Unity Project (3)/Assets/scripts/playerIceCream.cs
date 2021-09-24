using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIceCream : MonoBehaviour
{
 
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookIceCream.firstItemTimeToCook, cookIceCream.secondItemTimeToCook, cookIceCream.thirdItemTimeToCook };
    public int value;
    public PlayerData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataIceCream();
        cookIceCream.oneTimer = PlayerData.oneTimerIceCream;


        transform.position = PlayerData.LocationIceCream;
        // cookMilkFactory = this.gameObject.GetComponent<cookMilkFactory>();
       cookIceCream.imageSlotArray = PlayerData.imSlotArrayIceCream;

        cookIceCream.slotArray = PlayerData.slotArrayIceCream;
        if (PlayerData.valueForBoolIceCream == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolIceCream == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        value = cookIceCream.slotArray[0];

        if ((cookIceCream.slotArray[0] != 0) || (cookIceCream.slotArray[1] != 0))
        {
           cookIceCream.oneTimer = PlayerData.oneTimerIceCream += TimeMaster.CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookIceCream.slotArray[0] != 0) && (cookIceCream.slotArray[1] == 0))
        {
            float diference = TimeMaster.CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];

            cookIceCream.oneTimer = PlayerData.oneTimerGrill += diferenceTwo;
            // float diference = TimeMaster.instance.CheckDate();
            //  float diferenceTwo = diference -= cookIceCream.thirdItemTimeToCook;
            // cookIceCream.oneTimer = PlayerData.oneTimerSpagetti += diferenceTwo;
        }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataIceCream(this);
    }
    private void Update()
    {
        OneTimer = cookIceCream.oneTimer;
        slArZero = cookIceCream.slotArray[0];
        slArOne = cookIceCream.slotArray[1];
        imSlArZero = cookIceCream.imageSlotArray[0];
        imSlArOne = cookIceCream.imageSlotArray[1];

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
