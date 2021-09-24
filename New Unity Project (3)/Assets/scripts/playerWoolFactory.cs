using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWoolFactory : MonoBehaviour
{

    //public GameObject building;
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookWoolFactory.sugarTimeToCook, cookWoolFactory.coffeTimeToCook };
    public int value;
    public PlayerData PlayerData { get; private set; }
    private void Start()
    {

    }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataWoolFactory();
        cookWoolFactory.oneTimer = PlayerData.oneTimerWoolFactory;


        transform.position = PlayerData.LocationWoolFactory;

        cookWoolFactory.imageSlotArray = PlayerData.imSlotArrayWoolFactory;

        cookWoolFactory.slotArray = PlayerData.slotArrayWoolFactory;
        if (PlayerData.valueForBoolWoolFactory == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolWoolFactory == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        value = cookWoolFactory.slotArray[0];
        if ((cookWoolFactory.slotArray[0] != 0) || (cookWoolFactory.slotArray[1] != 0))
        {
            cookWoolFactory.oneTimer = PlayerData.oneTimerWoolFactory += TimeMaster.CheckDate();
            //  cookJuice.oneTimer = PlayerData.oneTimerSquizzer += TimeMaster.instance.CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookWoolFactory.slotArray[0] != 0) && (cookWoolFactory.slotArray[1] == 0))
        {
            float diference = TimeMaster.CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];
            if (diference > 0)
            {
                cookWoolFactory.oneTimer = PlayerData.oneTimerWoolFactory += diferenceTwo;
            }
            //float diference = TimeMaster.instance.CheckDate();
            //    float diferenceTwo = diference -= cookJuice.thirdItemTimeToCook;
            //   cookJuice.oneTimer = PlayerData.oneTimerSquizzer += diferenceTwo;
        }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataWoolFactory(this);
    }
    private void Update()
    {
        OneTimer = cookWoolFactory.oneTimer;
        slArZero = cookWoolFactory.slotArray[0];
        slArOne = cookWoolFactory.slotArray[1];
        imSlArZero = cookWoolFactory.imageSlotArray[0];
        imSlArOne = cookWoolFactory.imageSlotArray[1];
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
