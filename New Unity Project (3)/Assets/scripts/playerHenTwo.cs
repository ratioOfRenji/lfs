using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHenTwo : MonoBehaviour
{
    public float oneTimer;
    public Sprite One;
    public Sprite Two;
    public GameObject head;
    public int valueSprite;
    // Start is called before the first frame update
    public animalsData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataHenOne();

        if (PlayerData.spriteVaueHenOne == 1)
        {
            head.GetComponent<SpriteRenderer>().sprite = One;
        }
        if (PlayerData.spriteVaueHenOne == 2)
        {
            head.GetComponent<SpriteRenderer>().sprite = Two;
        }

        hen.growTimeSheep = PlayerData.oneTimerHenOne;
        if(hen.growTimeSheep > 0)
        {
            if(hen.growTimeSheep < 60)
            {
              hen.growTimeSheep = PlayerData.oneTimerHenOne += TimeMaster.CheckDate();
            }
           
        }
    }
    private void OnDisable()
    {
        playerPrefAnimals.SaveDataHenOne(this);
    }
    // Update is called once per frame
    void Update()
    {
        oneTimer = hen.growTimeSheep;
        if(head.GetComponent<SpriteRenderer>().sprite == One)
        {
            valueSprite = 1;
        }
        if (head.GetComponent<SpriteRenderer>().sprite == Two)
        {
            valueSprite = 2;
        }
    }
}
