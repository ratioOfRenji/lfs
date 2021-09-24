using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGoat : MonoBehaviour
{
    public float oneTimer;
    public Sprite One;
    public Sprite Two;
    public GameObject head;
    public int valueSprite;
    public int valueForBool;
    public animalsData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataGoat();

        if (PlayerData.spriteVaueGoat == 1)
        {
            head.GetComponent<SpriteRenderer>().sprite = One;
        }
        if (PlayerData.spriteVaueGoat == 2)
        {
            head.GetComponent<SpriteRenderer>().sprite = Two;
        }

        goat.growTimeSheep = PlayerData.oneTimerGoat;
        if (goat.growTimeSheep > 0)
        {
            if (goat.growTimeSheep < 60)
            {
                goat.growTimeSheep = PlayerData.oneTimerSheep += TimeMaster.CheckDate();
            }

        }
    }
    private void OnDisable()
    {
        playerPrefAnimals.SaveDataGoat(this);
    }
    // Update is called once per frame
    void Update()
    {
        oneTimer = goat.growTimeSheep;
        if (head.GetComponent<SpriteRenderer>().sprite == One)
        {
            valueSprite = 1;
        }
        if (head.GetComponent<SpriteRenderer>().sprite == Two)
        {
            valueSprite = 2;
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
