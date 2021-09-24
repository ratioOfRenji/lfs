using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBakery : MonoBehaviour
{
    public GameObject building;
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookBakery.sugarTimeToCook, cookBakery.coffeTimeToCook};
    public int value;
    public PlayerData PlayerData { get; private set; }
    private void Start()
    {

    }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataBakery();
        cookBakery.oneTimer = PlayerData.oneTimerBakery;


        transform.position = PlayerData.LocationBakery;

        cookBakery.imageSlotArray = PlayerData.imSlotArrayBakery;

        cookBakery.slotArray = PlayerData.slotArrayBakery;
        if (PlayerData.valueForBoolBakery == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolBakery == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        value = cookBakery.slotArray[0];
        if ((cookBakery.slotArray[0] != 0) || (cookBakery.slotArray[1] != 0))
        {
            cookBakery.oneTimer = PlayerData.oneTimerBakery += TimeMaster.CheckDate();
            //  cookJuice.oneTimer = PlayerData.oneTimerSquizzer += TimeMaster.instance.CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookBakery.slotArray[0] != 0) && (cookBakery.slotArray[1] == 0))
        {
            float diference = TimeMaster.CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];
            if (diference > 0)
            {
                cookBakery.oneTimer = PlayerData.oneTimerBakery += diferenceTwo;
            }
            //float diference = TimeMaster.instance.CheckDate();
            //    float diferenceTwo = diference -= cookJuice.thirdItemTimeToCook;
            //   cookJuice.oneTimer = PlayerData.oneTimerSquizzer += diferenceTwo;
        }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataBakery(this);
    }
    private void Update()
    {
        OneTimer = cookBakery.oneTimer;
        slArZero = cookBakery.slotArray[0];
        slArOne = cookBakery.slotArray[1];
        imSlArZero = cookBakery.imageSlotArray[0];
        imSlArOne = cookBakery.imageSlotArray[1];
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
