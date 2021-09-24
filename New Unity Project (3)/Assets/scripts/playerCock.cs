using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCock : MonoBehaviour
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
        PlayerData = playerPrefAnimals.LoadDataCock();

        if (PlayerData.spriteVaueCock == 1)
        {
            head.GetComponent<SpriteRenderer>().sprite = One;
        }
        if (PlayerData.spriteVaueCock == 2)
        {
            head.GetComponent<SpriteRenderer>().sprite = Two;
        }

       cock.growTimeSheep = PlayerData.oneTimerCock;
        if (cock.growTimeSheep > 0)
        {
            if (cock.growTimeSheep < 60)
            {
                cock.growTimeSheep = PlayerData.oneTimerCock += TimeMaster.CheckDate();
            }

        }
    }
    private void OnDisable()
    {
        playerPrefAnimals.SaveDataCock(this);
    }
    // Update is called once per frame
    void Update()
    {
        oneTimer = cock.growTimeSheep;
        if (head.GetComponent<SpriteRenderer>().sprite == One)
        {
            valueSprite = 1;
        }
        if (head.GetComponent<SpriteRenderer>().sprite == Two)
        {
            valueSprite = 2;
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
