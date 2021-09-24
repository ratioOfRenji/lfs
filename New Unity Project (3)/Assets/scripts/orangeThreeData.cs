﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeThreeData : MonoBehaviour
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

        PlayerData = playerPrefTrees.LoadDataOrangeThree();
        tree.GetComponent<wateringRaspberry>().timer = PlayerData.timerOrangeThree;


        tree.transform.position = PlayerData.LocationThirdOrange;
        if (PlayerData.boolOrangeThree == 1)
        {
            tree.GetComponent<wateringRaspberry>().startTimer = true;
        }
        if (PlayerData.boolOrangeThree == 0)
        {
            tree.GetComponent<wateringRaspberry>().startTimer = false;
        }

        if (PlayerData.spritesOrangeThree == 0)
        {
            tree.GetComponent<SpriteRenderer>().sprite = regular;
        }
        if (PlayerData.spritesOrangeThree == 1)
        {
            tree.GetComponent<SpriteRenderer>().sprite = watered;
        }
        if (PlayerData.spritesOrangeThree == 2)
        {
            tree.GetComponent<SpriteRenderer>().sprite = ready;
        }

        if (PlayerData.boolOrangeThree == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.boolOrangeThree == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
        if (PlayerData.spritesOrangeThree == 1)
        {
            this.gameObject.GetComponent<wateringRaspberry>().timer = PlayerData.timerOrangeThree += TimeMaster.CheckDate();
            // cookSpagettiMachine.oneTimer = PlayerData.oneTimerSpagetti += TimeMaster.instance.CheckDate();
        }

    }

    private void OnDisable()
    {
        playerPrefTrees.SaveDataOrangeThree(this);
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
