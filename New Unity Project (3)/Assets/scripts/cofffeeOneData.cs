using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofffeeOneData : MonoBehaviour
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
    public static float realTime;
    public float oneTimeTwo;

    public dataForTrees PlayerData { get; private set; }
    private void OnEnable()
    {

        PlayerData = playerPrefTrees.LoadDataCoffeeOne();
        tree.GetComponent<wateringRaspberry>().timer = PlayerData.timerAppleThree;


        tree.transform.position = PlayerData.LocationFirstCoffee;
        if (PlayerData.boolCoffeeOne == 1)
        {
            tree.GetComponent<wateringRaspberry>().startTimer = true;
        }
        if (PlayerData.boolCoffeeOne == 0)
        {
            tree.GetComponent<wateringRaspberry>().startTimer = false;
        }

        if (PlayerData.spritesCoffeeOne == 0)
        {
            tree.GetComponent<SpriteRenderer>().sprite = regular;
        }
        if (PlayerData.spritesCoffeeOne == 1)
        {
            tree.GetComponent<SpriteRenderer>().sprite = watered;
        }
        if (PlayerData.spritesCoffeeOne == 2)
        {
            tree.GetComponent<SpriteRenderer>().sprite = ready;
        }

        if (PlayerData.boolCoffeeOne == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.boolCoffeeOne == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        if (PlayerData.spritesCoffeeOne == 1)
        {
            this.gameObject.GetComponent<wateringRaspberry>().timer = PlayerData.timerCoffeeOne += TimeMaster.CheckDate();
            // cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti += TimeMaster.instance.CheckDate();
        }

    }

    private void OnDisable()
    {
        playerPrefTrees.SaveDataCoffeeOne(this);
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
