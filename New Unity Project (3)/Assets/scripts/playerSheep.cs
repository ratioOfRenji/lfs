using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSheep : MonoBehaviour
{
    public float oneTimer;
    public Sprite One;
    public Sprite Two;
    public Sprite three;
    public Sprite bodyOne;
    public Sprite bodyTwo;
    public GameObject head;
    public GameObject body;
    public int valueSprite;
    public int valueBodySprite;
    public int valueForBool;
    public animalsData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataSheep();

        if (PlayerData.spriteVaueSheep == 1)
        {
            head.GetComponent<SpriteRenderer>().sprite = One;
        }
        if (PlayerData.spriteVaueSheep == 2)
        {
            head.GetComponent<SpriteRenderer>().sprite = Two;
        }
        if (PlayerData.spriteVaueSheep == 3)
        {
            head.GetComponent<SpriteRenderer>().sprite = three;
        }
        if (PlayerData.spriteBodyVaueSheep == 1)
        {
            body.GetComponent<SpriteRenderer>().sprite = bodyOne;
        }
        if (PlayerData.spriteBodyVaueSheep == 2)
        {
            body.GetComponent<SpriteRenderer>().sprite = bodyTwo;
        }

        sheep.growTimeSheep = PlayerData.oneTimerSheep;
        if (sheep.growTimeSheep > 0)
        {
            if (sheep.growTimeSheep < 180)
            {
                sheep.growTimeSheep = PlayerData.oneTimerSheep += TimeMaster.CheckDate();
            }

        }
    }
    private void OnDisable()
    {
        playerPrefAnimals.SaveDataSheep(this);
    }
    // Update is called once per frame
    void Update()
    {
        oneTimer = sheep.growTimeSheep;
        if (head.GetComponent<SpriteRenderer>().sprite == One)
        {
            valueSprite = 1;
        }
        if (head.GetComponent<SpriteRenderer>().sprite == Two)
        {
            valueSprite = 2;
        }
        if (head.GetComponent<SpriteRenderer>().sprite == three)
        {
            valueSprite = 3;
        }
        if (body.GetComponent<SpriteRenderer>().sprite == bodyOne)
        {
            valueBodySprite = 1;
        }
        if (body.GetComponent<SpriteRenderer>().sprite == bodyTwo)
        {
            valueBodySprite = 2;
        }
        //if (this.gameObject.GetComponent<dragAfterBought>().bought == true)
        //{
        //    valueForBool = 1;
        //}
        //if (this.gameObject.GetComponent<dragAfterBought>().bought == false)
        //{
        //    valueForBool = 0;
        //}
    }
}
