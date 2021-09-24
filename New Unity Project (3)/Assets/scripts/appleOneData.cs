using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class appleOneData : MonoBehaviour
{

    public float _timer;
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

        PlayerData = playerPrefTrees.LoadDataAppleOne();
        tree.GetComponent<wateringRaspberry>().timer = PlayerData.timerAppleOne;


        tree.transform.position = PlayerData.LocationFirstApple;
        if (PlayerData.boolAppleOne == 1)
        {
          //  tree.GetComponent<wateringRaspberry>().startTimer = true;
        }
        if (PlayerData.boolAppleOne == 0)
        {
          //  tree.GetComponent<wateringRaspberry>().startTimer = false;
        }

        if (PlayerData.spritesAppleOne == 0)
        {
            tree.GetComponent<SpriteRenderer>().sprite = regular;
        }
        if (PlayerData.spritesAppleOne == 1)
        {
            tree.GetComponent<SpriteRenderer>().sprite = watered;
        }
        if (PlayerData.spritesAppleOne == 2)
        {
            tree.GetComponent<SpriteRenderer>().sprite = ready;
        }

        
        if (PlayerData.boolAppleOne == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
           this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.boolAppleOne == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        if (PlayerData.spritesAppleOne == 1)
        {
            this.gameObject.GetComponent<wateringRaspberry>().timer = PlayerData.timerAppleOne += CheckDate();
            // cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti += TimeMaster.instance.CheckDate();
        }

    }
    private void OnDisable()
    {
        playerPrefTrees.SaveDataAppleOne(this);
        ResetClock();
    }
    private void Update()
    {
        _timer =this.gameObject.GetComponent<wateringRaspberry>().timer;
        startTimer = this.gameObject.GetComponent<wateringRaspberry>().startTimer;

        if (regular == this.gameObject.GetComponent<SpriteRenderer>().sprite)
        {
            valueForImages = 0;
        }
        if (watered == this.gameObject.GetComponent<SpriteRenderer>().sprite)
        {
            valueForImages = 1;
        }
        if (ready == this.gameObject.GetComponent<SpriteRenderer>().sprite)
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
