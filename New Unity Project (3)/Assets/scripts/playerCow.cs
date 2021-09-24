using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCow : MonoBehaviour
{
    public float oneTimer;
    public Sprite One;
    public Sprite Two;
    public GameObject head;
    public int valueSprite;
    public int valueForBool;
    public static float helpForHen;
    public animalsData PlayerData { get; private set; }

    private void Awake()
    {
          helpForHen = TimeMaster.CheckDate();
    }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataCow();

        if (PlayerData.spriteVaueCow == 1)
        {
            head.GetComponent<SpriteRenderer>().sprite = One;
        }
        if (PlayerData.spriteVaueCow == 2)
        {
            head.GetComponent<SpriteRenderer>().sprite = Two;
        }

        cow.growTimeSheep = PlayerData.oneTimerCow;
      
        if (cow.growTimeSheep > 0)
        {
            if (cow.growTimeSheep < 60)
            {
                cow.growTimeSheep = PlayerData.oneTimerCow += TimeMaster.CheckDate();
            }

        }
    }
    private void OnDisable()
    {
        playerPrefAnimals.SaveDataCow(this);
    }
    // Update is called once per frame
    void Update()
    {
        oneTimer = cow.growTimeSheep;
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
