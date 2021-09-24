using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class TimeMaster : MonoBehaviour
{
    static DateTime currentDate;
    DateTime oldDate;
    public static string saveLocation;
    
    public static float realTime;
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
    private void Update()
    {
       
        
    }
}
