using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raspberryOneData : MonoBehaviour
{
    
    
    public float timer;
    public bool startTimer;
    public int valueForBool;
    public int valueForImages;
    public Sprite[] raspberryOneSprites;
    public GameObject raspberryOne;
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

    public dataForTrees PlayerData { get; private set; }
    private void OnEnable()
    {
        //PlayerPrefs.DeleteAll();
        realTime = TimeMaster.realTime;
        
        oneTimeTwo = realTime;
        
       PlayerData = playerPrefTrees.LoadData();
        raspberryOne.GetComponent<wateringRaspberry>().timer = PlayerData.timerRaspberryOne;


        raspberryOne.transform.position = PlayerData.Location;
        if(PlayerData.boolRaspberryOne ==1)
        {
            raspberryOne.GetComponent<wateringRaspberry>().startTimer = true;
        }
        if (PlayerData.boolRaspberryOne == 0)
        {
            raspberryOne.GetComponent<wateringRaspberry>().startTimer = false;
        }

        if(PlayerData.spritesRaspberryOne == 0)
        {
            raspberryOne.GetComponent<SpriteRenderer>().sprite = regular;
        }
        if (PlayerData.spritesRaspberryOne == 1)
        {
            raspberryOne.GetComponent<SpriteRenderer>().sprite = watered;
        }
        if (PlayerData.spritesRaspberryOne == 2)
        {
            raspberryOne.GetComponent<SpriteRenderer>().sprite = ready;
        }

        if (PlayerData.boolRaspberryOne == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.boolRaspberryOne == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        if (PlayerData.boolRaspberryOne == 1)
        {
            this.gameObject.GetComponent<wateringRaspberry>().timer = PlayerData.timerRaspberryOne += TimeMaster.CheckDate();
            // cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti += TimeMaster.instance.CheckDate();
        }

    }
   
    private void OnDisable()
    {
       playerPrefTrees.SaveData(this);
    }
    private void Update()
    {
        timer = raspberryOne.GetComponent<wateringRaspberry>().timer;
        startTimer = raspberryOne.GetComponent<wateringRaspberry>().startTimer;
        
        if(regular == raspberryOne.GetComponent<SpriteRenderer>().sprite)
        {
            valueForImages = 0;
        }
        if (watered == raspberryOne.GetComponent<SpriteRenderer>().sprite)
        {
            valueForImages = 1;
        }
        if (ready == raspberryOne.GetComponent<SpriteRenderer>().sprite)
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
