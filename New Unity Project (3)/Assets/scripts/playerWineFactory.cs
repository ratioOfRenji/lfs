using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerWineFactory : MonoBehaviour
{
    
    public int slArZero;
    public int slArOne;
    public int imSlArZero;
    public int imSlArOne;
    public float OneTimer;
    public bool startOneTimer;
    public int valueForBool;
    public float[] reqTimers = { cookWineFactory.firstTimeToCook, cookWineFactory.secondTimeToCook, cookWineFactory.thirdTimeToCook };
    public int value;
    static DateTime currentDate;
    DateTime oldDate;
    public static string saveLocation;

    void Awake()
    {
        // Create instance of our Datemaster script  
      
        // Set our player prefs to the save location
        saveLocation = "lastSavedDate1";
    }
    //Checks the current time against the saved time
    public static float CheckDate()
    {
        // store the current time when it starts
        currentDate = System.DateTime.Now;
        string tempString = PlayerPrefs.GetString(saveLocation, "1");
        // Grab the old time from the player prefs as a long
        long tempLong = Convert.ToInt64(tempString);
        //Convert the old time from binary to a DateTime varible
        DateTime oldDate = DateTime.FromBinary(tempLong);
        print("oldDate : " + oldDate);
        //use the subtract method and store the result as a timespan
        TimeSpan difference = currentDate.Subtract(oldDate);
        print("difference :" + difference);
        return (float)difference.TotalSeconds;
    }
    // Saves the current time, this is necessary so we can acccuratly check the difference later
    public static void SaveDate()
    {
        // save the current system time
        PlayerPrefs.SetString(saveLocation, System.DateTime.Now.ToBinary().ToString());
        print("Saving this date to player prefs" + System.DateTime.Now);
    }
    void ResetClock()
    {
        SaveDate();

    }
    public PlayerData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefsData.LoadDataWineFactory();
     //  cookWineFactory.oneTimer = PlayerData.oneTimerWineFactory;


        transform.position = PlayerData.LocationWineFactory;
        
        cookWineFactory.imageSlotArray = PlayerData.imSlotArrayWineFactory;
//
       cookWineFactory.slotArray = PlayerData.slotArrayWineFactory;
        if (PlayerData.valueForBoolWineFactory == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolWineFactory == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        value = cookWineFactory.slotArray[0];

        if ((cookWineFactory.slotArray[0] != 0) || (cookWineFactory.slotArray[1] != 0))
        {
          cookWineFactory.oneTimer = PlayerData.oneTimerWineFactory += CheckDate();
        }
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(2);
        if ((cookWineFactory.slotArray[0] != 0) && (cookWineFactory.slotArray[1] == 0))
        {
            float diference = CheckDate();
            float diferenceTwo = diference -= reqTimers[value - 1];
            if (diference > 0)
            {
                cookWineFactory.oneTimer = PlayerData.oneTimer += diferenceTwo;
            }
        }

    }
    private void OnDisable()
    {
        playerPrefsData.SaveDataWineFactory(this);
        ResetClock();
    }
    private void Update()
    {
        OneTimer = cookWineFactory.oneTimer;
        slArZero = cookWineFactory.slotArray[0];
        slArOne = cookWineFactory.slotArray[1];
        imSlArZero = cookWineFactory.imageSlotArray[0];
        imSlArOne = cookWineFactory.imageSlotArray[1]; 
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
