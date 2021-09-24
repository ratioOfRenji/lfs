using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHenOne : MonoBehaviour
{
    
    public float OneTimer;
    public int spriteValue;
    public int valueForBool;
    public float[] reqTimers = { cookSpagettiMachine.firstItemTimeToCook, cookSpagettiMachine.secondItemTimeToCook, cookSpagettiMachine.thirdItemTimeToCook };
    public int value;
    public Sprite One;
    public Sprite Two;
    public GameObject head;
    public animalsData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataHenOne();

        if(PlayerData.spriteVaueHenOne ==1)
        {
            head.GetComponent<SpriteRenderer>().sprite = One;
        }
        if (PlayerData.spriteVaueHenOne == 2)
        {
            head.GetComponent<SpriteRenderer>().sprite = Two;
        }

        hen.growTimeSheep = PlayerData.oneTimerHenOne;
        if(PlayerData.oneTimerHenOne > 0)
        {
           // this.gameObject.GetComponent<hen>().growTimeSheep = PlayerData.oneTimerHenOne += TimeMaster.CheckDate();
        }

        if (PlayerData.valueForBoolHen == 1)
        {
           // this.gameObject.GetComponent<dragAfterBought>().bought = true;
           // this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolHen == 0)
        {
           // this.gameObject.GetComponent<dragAfterBought>().bought = false;
            //this.gameObject.GetComponent<dragAfterBought>().set = false;
        }

    }

    private void OnDisable()
    {
       // playerPrefAnimals.SaveDataHenOne(this);
    }
    private void Update()
    {

        if (this.gameObject.GetComponent<dragAfterBought>().bought == true)
        {
            valueForBool = 1;
        }
        if (this.gameObject.GetComponent<dragAfterBought>().bought == false)
        {
            valueForBool = 0;
        }
        if (One == head.GetComponent<SpriteRenderer>().sprite  )
        {
          spriteValue =1;
        }
        if (Two ==  head.GetComponent<SpriteRenderer>().sprite)
        {
            spriteValue = 2;
        }
        OneTimer = hen.growTimeSheep;
    }
}
