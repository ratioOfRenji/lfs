using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class dataForHen : MonoBehaviour
{
    public float timer;
    public float timerMaxValue;
    public GameObject head;
    public Sprite headone;
    public Sprite headtwo;
    public Animator anim;
    private int spriteValue;
    public GameObject particles;

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
    void ResetClock()
    {
       SaveDate();
      
    }
    private void OnMouseDown()
    {
        if ((GMScript1.currentTool == "кормить") && (GMScript1.sunFlowerSeeds > 0) && (timer < timerMaxValue))
        {
            head.GetComponent<SpriteRenderer>().sprite = headtwo;
        }
        if(timer >= timerMaxValue)
        {
            GMScript1.yaytsa++;
            timer = 0;
            StartCoroutine(waitBeforeStop());
        }

    }
    IEnumerator waitBeforeStop()
    {
        anim.Play("eggAnimation");
        yield return new WaitForSeconds(2);
        anim.Play("eggTransparent");
        hen.animationTrigger = false;
    }
    private void Update()
    {
        if(head.GetComponent<SpriteRenderer>().sprite == headtwo)
        {
            timer += Time.deltaTime;
        }
        if(timer >= timerMaxValue)
        {
            head.GetComponent<SpriteRenderer>().sprite = headone;
            particles.SetActive(true);
        }
        if(timer < timerMaxValue)
        {
            particles.SetActive(false);
        }

        if (head.GetComponent<SpriteRenderer>().sprite == headone)
        {
            spriteValue = 0;
        }
        if (head.GetComponent<SpriteRenderer>().sprite == headtwo)
        {
            spriteValue = 1;
        }
        
    }

    private void saveData()
    {
        PlayerPrefs.SetInt("spriteValueKuritsa", spriteValue);
        PlayerPrefs.SetFloat("timerFoRKuritsa", timer);
    }
    private void loadData()
    { 
        timer = CheckDate();
        int val = PlayerPrefs.GetInt("spriteValueKuritsa");
        float tim =PlayerPrefs.GetFloat("timerFoRKuritsa");
        timer = tim;
        if (val ==0)
        {
           
            head.GetComponent<SpriteRenderer>().sprite = headone;
        }
        if (val == 1)
        {
           
            head.GetComponent<SpriteRenderer>().sprite = headtwo;
        }
       
        if(head.GetComponent<SpriteRenderer>().sprite == headtwo)
        {
            timer = tim + CheckDate();

        }
    }
    private void OnEnable()
    {
        loadData();
    }
    private void OnDisable()
    {
        saveData();
        ResetClock();
    }
}
