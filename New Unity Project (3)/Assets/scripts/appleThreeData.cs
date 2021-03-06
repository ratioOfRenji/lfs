using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class appleThreeData : MonoBehaviour
{
    public float timer;
    public bool startTimer;
    public int valueForBool;
    public int valueForImages;
    public Sprite[] raspberryOneSprites;
    public GameObject tree;
    [SerializeField]
    private Sprite regular;
    [SerializeField]
    private Sprite watered;
    [SerializeField]
    private Sprite ready;
    public wateringRaspberry wateringRaspberry;
    //public float diference = TimeMaster.instance.CheckDate();
   // public static float realTime;
   // public float oneTimeTwo;
    public static float realTime;
    public float oneTimeTwo;
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
    public dataForTrees PlayerData { get; private set; }
    private void OnEnable()
    {

        PlayerData = playerPrefTrees.LoadDataAppleThree();
        tree.GetComponent<wateringRaspberry>().timer = PlayerData.timerAppleThree;


        tree.transform.position = PlayerData.LocationThirdApple;
        if (PlayerData.boolAppleThree == 1)
        {
            tree.GetComponent<wateringRaspberry>().startTimer = true;
        }
        if (PlayerData.boolAppleThree == 0)
        {
            tree.GetComponent<wateringRaspberry>().startTimer = false;
        }

        if (PlayerData.spritesAppleThree == 0)
        {
            tree.GetComponent<SpriteRenderer>().sprite = regular;
        }
        if (PlayerData.spritesAppleThree == 1)
        {
            tree.GetComponent<SpriteRenderer>().sprite = watered;
        }
        if (PlayerData.spritesAppleThree == 2)
        {
            tree.GetComponent<SpriteRenderer>().sprite = ready;
        }

        if (PlayerData.boolAppleThree == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
           this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.boolAppleThree == 0)
        {
           this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        if (PlayerData.spritesAppleThree == 1)
        {
            this.gameObject.GetComponent<wateringRaspberry>().timer = PlayerData.timerAppleThree += CheckDate();
            // cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti += TimeMaster.instance.CheckDate();
        }

    }

    private void OnDisable()
    {
        playerPrefTrees.SaveDataAppleThree(this); 
        ResetClock();
    }
    private void Update()
    {
        timer = tree.GetComponent<wateringRaspberry>().timer;
        startTimer = tree.GetComponent<wateringRaspberry>().startTimer;

        if (regular == tree.GetComponent<SpriteRenderer>().sprite)
        {
            valueForImages = 0;
        }
        if (watered == tree.GetComponent<SpriteRenderer>().sprite)
        {
            valueForImages = 1;
        }
        if (ready == tree.GetComponent<SpriteRenderer>().sprite)
        {
            valueForImages = 2;
        }

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
